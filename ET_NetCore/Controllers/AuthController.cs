using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AutoMapper;
using ET.Domain.Entities.Auth;
using ET.Domain.Entities.Types;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.DTO.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ET_NetCore.API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IIndividualRepository _individualRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        

        public AuthController(IConfiguration config, UserManager<User> userManager, SignInManager<User> signInManager,
            IIndividualRepository individualRepository, IMapper mapper, IEmailSender emailSender)
        {
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            _individualRepository = individualRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userToCreate = new User
            {
                UserName = userForRegisterDto.Username,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email
            };

            var result = await _userManager.CreateAsync(userToCreate, userForRegisterDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(userToCreate, userForRegisterDto.Role.ToUpper());

                var userCreated = await _userManager.FindByNameAsync(userToCreate.UserName);

                //auto create new Individual for Individual Account Register
                if (userForRegisterDto.Role.ToUpper() == AccountTypes.Individual.ToString().ToUpper())
                {
                    var newIndividual = new ET.Domain.Entities.Aggregate.CustomerAggregate.Individual
                    {
                        AccountUserId = userCreated.Id,
                        FirstName = userCreated.FirstName,
                        LastName = userCreated.LastName,
                        Email = userCreated.Email,
                        DateTimeCreated = DateTime.Now
                    };

                    _individualRepository.Add(newIndividual);
                    var saveResult = await _individualRepository.SaveAll();

                    if (!saveResult)
                        return BadRequest("Something is Wrong When creating the account.");
                }
                var userForReturn = _mapper.Map<UserForReturnDto>(userCreated);
                return CreatedAtRoute("GetUser", new { controller = "Account", id = userCreated.Id }, userForReturn);
            }

            return BadRequest(result.Errors);


        }

        [HttpPost("Login", Name = "LoginRoute")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var user = await _userManager.FindByNameAsync(userForLoginDto.Username);

            if (user == null)
            {
                return BadRequest("No account is found");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, userForLoginDto.Password, false);

            if (result.Succeeded)
            {
                return Ok(new
                {
                    EmailVerified = user.EmailConfirmed,
                    token = GenerateJwtToken(user)
                });

            }

           
            return Unauthorized();
        }

        [HttpGet("SendVerifyEmail")]
        public async Task<IActionResult> SendVerifyEmail()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user.EmailConfirmed) return BadRequest("User Email Already Verified!");

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //var callbackUrl = Url.Action("ConfirmEmail","Auth",new { userId = user.Id, code = code },Request.Scheme);
            var callbackUrl = $"https://localhost:4200/ConfirmEmail/{user.Id}/{code}";

            await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            return Ok();
        }

        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(int userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return Ok("Email Verified!");
            }

            return BadRequest(result.Errors);
        }

        [AllowAnonymous]
        [HttpPost("SendPasswordReset")]
        public async Task<IActionResult> SendPasswordReset(string inputEmail)
        {
            User user = await _userManager.FindByEmailAsync(inputEmail);
            if (user == null)return NotFound();

            //if (!_userManager.IsEmailConfirmedAsync(user).Result)
            //    return BadRequest("Email not verified! Verify Email first!");

            var code = await _userManager.
                GeneratePasswordResetTokenAsync(user);
            
            //front end UI routing
            //var callbackUrl = Url.Action("ResetPassword", "Auth", new { userId = user.Id, code = code }, Request.Scheme);
            var callbackUrl = $"https://localhost:4200/ResetPassword/{user.Id}/{code.Replace("/","%2F")}";
            await _emailSender.SendEmailAsync(user.Email, "Reset Password",
                $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto dto)
        {
            User user = await _userManager.FindByNameAsync(dto.UserName);

            IdentityResult result = await _userManager.ResetPasswordAsync
                (user, dto.Token, dto.Password);

            if (result.Succeeded) return Ok();

            return BadRequest("Error Reset Password");
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var roles = _userManager.GetRolesAsync(user).Result;

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }




    }
}