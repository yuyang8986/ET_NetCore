using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Application.Services.Individual;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet
{
    public class MainFormGetQueryHandler:IRequestHandler<MainFormGetQuery, MainFormGetModel>
    {
        private readonly IMainformRepository _mainformRepository;
        private readonly IMapper _mapper;
        private readonly IIndividualRepository _individualRepository;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MainFormGetQueryHandler(IMainformRepository mainformRepository, IMapper mapper, IIndividualRepository individualRepository, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _mainformRepository = mainformRepository;
            _mapper = mapper;
            _individualRepository = individualRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<MainFormGetModel> Handle(MainFormGetQuery request, CancellationToken cancellationToken)
        {
            var mainForm = await _mainformRepository.Get(request.Id);
            if (mainForm == null) throw new NotFoundException(nameof(MainForm),request.Id);
            User usr = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (usr == null) throw new AuthenticationException("Not Authorized");

            var individualOwnThisMainform = mainForm.IITRLodgement.Individual;
            if(individualOwnThisMainform == null) throw new AuthenticationException("Not Authorized");

            IndividualSecurity.CheckIndividualAccessibleByCurrentUser(individualOwnThisMainform.IndividualId, usr, _individualRepository);
            MainFormGetModel model = _mapper.Map<MainFormGetModel>(mainForm);
            return model;
        }
    }
}
