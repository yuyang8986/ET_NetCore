using System;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Application.Services.Individual;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.Individual.IndividualCommand
{
    public class IndividualUpdateCommandHandler:IRequestHandler<IndividualUpdateCommand, IndividualUpdatedModel>
    {
        private readonly UserManager<User> _userManager;
        private readonly IIndividualRepository _individualRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly ETContext _context;

        public IndividualUpdateCommandHandler(UserManager<User> userManager, IIndividualRepository individualRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper, ETContext context)
        {
            _userManager = userManager;
            _individualRepository = individualRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;
        }

        public async Task<IndividualUpdatedModel> Handle(IndividualUpdateCommand request, CancellationToken cancellationToken)
        {
            User usr = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if(usr == null) throw new AuthenticationException("Not Authorized");
            //check if current user and its individual is the same as from url
            IndividualSecurity.CheckIndividualAccessibleByCurrentUser(request.IndividualId, usr, _individualRepository);

            var individual = await _individualRepository.GetIndividualById(request.IndividualId);
            _mapper.Map(request, individual);
            var occupation = await _context.Occupations.FirstOrDefaultAsync(s => s.Name == request.Occupation, cancellationToken);

            //no occupation found in DB, create a new one with occupation category is uncategorised(100)
            if (occupation == null)
            {
                Occupation occupationNew = new Occupation{Name = request.Occupation, OccupationCategoryId = 100};
                _context.Occupations.Add(occupationNew);
                _context.SaveChanges();

                individual.Occupation = occupationNew;
            }

            else
            {
                individual.Occupation = occupation;
            }

            try
            {
                IndividualUpdatedModel model = _mapper.Map<IndividualUpdatedModel>(individual);
                _context.Individuals.Update(individual);

                //if individual email changed, also change account email and set emailConfirmed to false
                if(usr.Email != individual.Email) usr.EmailConfirmed = false;
                usr.Email = individual.Email;
                usr.NormalizedEmail = individual.Email.ToUpper();
                _context.Users.Update(usr);
                if (await _individualRepository.SaveAll())
                {
                    return model;
                }

                model.Changed = false;
                return model;

            }
            catch (Exception e)
            {
                throw new Exception($"Updating Individual {request.IndividualId} failed on save, {e.Message}");
            }
           

            
            
        }
    }
}
