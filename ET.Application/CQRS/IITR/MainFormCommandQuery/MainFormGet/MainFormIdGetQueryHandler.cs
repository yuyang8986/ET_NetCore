using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ET.Application.Services.Individual;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet
{
    public class MainFormIdGetQueryHandler : IRequestHandler<MainFormIdGetQuery, MainFormIdGetModel>
    {
        private readonly IMainformRepository _mainformRepository;
        private readonly IIndividualRepository _individualRepository;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IIITRLodgementRepository _lodgementRepository;

        public MainFormIdGetQueryHandler(IMainformRepository mainformRepository, IIndividualRepository individualRepository, 
            UserManager<User> userManager, IHttpContextAccessor httpContextAccessor, IIITRLodgementRepository lodgementRepository)
        {
            _mainformRepository = mainformRepository;
            _individualRepository = individualRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _lodgementRepository = lodgementRepository;
        }


        public async Task<MainFormIdGetModel> Handle(MainFormIdGetQuery request, CancellationToken cancellationToken)
        {
            User usr = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (usr == null) throw new AuthenticationException("Not Authorized");

            var individual = await _individualRepository.GetIndividualByIndividualAccountUser(usr);

            if (individual == null) throw new NotFoundException(nameof(Domain.Entities.Aggregate.CustomerAggregate.Individual), usr.Id);

            IndividualSecurity.CheckIndividualAccessibleByCurrentUser(individual.IndividualId, usr, _individualRepository);

            //eager loading all items related to lodgment
            var lodgements = await _lodgementRepository.GetLodgementByIndividual(individual);

            foreach (var lodgement in lodgements)
            {
                if (lodgement.FinancialYear.Year == request.Year)
                {
                    return new MainFormIdGetModel{IndividualId = individual.IndividualId, MainFormId = lodgement.MainFormId};
                }
            }

            throw new NotFoundException(nameof(MainFormIdGetModel), individual.IndividualId);
        }
    }
}
