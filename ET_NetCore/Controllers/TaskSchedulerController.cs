using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Domain.Entities.Auth;
using ET.Domain.Entities.Types;
using ET.Infrastructure.DataAccess;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ET_NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskSchedulerController : ControllerBase
    {
        private readonly IEmailSender _emailSender;
        private readonly ETContext _context;
        private readonly UserManager<User> _userManager;

        public TaskSchedulerController(IEmailSender emailSender,ETContext context, UserManager<User> userManager)
        {
            _emailSender = emailSender;
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("SendEmailReminder")]
        public async Task<IActionResult> SendEmailReminder()
        {
            //if (User.Claims.First().Properties["Role"] != "SuperAdmin") return Unauthorized();
            RecurringJob.AddOrUpdate(() => Run(), Cron.Daily);

            return Ok();
        }

        public async Task Run()
        {
            List<IITRLodgement> iitrLodgements = await _context.IITRLodgements.Include(x => x.Individual)
                .Where(s => s.LodgementStatus == LodgementStatus.Incomplete).ToListAsync();

            foreach (var lodgement in iitrLodgements)
            {
                string emailTo = _context.Individuals.FindAsync(lodgement.IndividualId).Result.Email;
                string body = $"Please Complete Your Tax Return by clicking here: http://localhost:4200/login";
                string from = "no-replay@etaccounting.net";
                string subject = "Reminder for your tax return";

                await _emailSender.SendEmailAsync(emailTo, subject, body);
            }
        }


    }
}