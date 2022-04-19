using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using ET.Application.Services.Individual;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ET.Application.CQRS.IITR.IndividualDashboardCommand
{
    public class IITRIndividualDashboardCommandHandler:IRequestHandler<IITRIndividualDashboardCommand, IITRIndividualDashboardModel>
    {
        private readonly IIITRLodgementRepository _lodgementRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IIndividualRepository _individualRepository;

        public IITRIndividualDashboardCommandHandler(IIITRLodgementRepository lodgementRepository,IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, IIndividualRepository individualRepository)
        {
            _lodgementRepository = lodgementRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _individualRepository = individualRepository;
        }
        public async Task<IITRIndividualDashboardModel> Handle(IITRIndividualDashboardCommand request, CancellationToken cancellationToken)
        {
            User usr = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            if (usr == null) throw new AuthenticationException("Not Authorized");

            var individual = await _individualRepository.GetIndividualByIndividualAccountUser(usr);

            if (individual == null) throw new NotFoundException(nameof(Domain.Entities.Aggregate.CustomerAggregate.Individual),usr.Id);

            IndividualSecurity.CheckIndividualAccessibleByCurrentUser(individual.IndividualId,usr,_individualRepository);

            //eager loading all items related to lodgment
            var lodgements = await _lodgementRepository.GetLodgementByIndividual(individual);

            var model = new IITRIndividualDashboardModel(lodgements,individual.IndividualId, individual.LastName, individual.FirstName);

            return model;
        }
    }
}
