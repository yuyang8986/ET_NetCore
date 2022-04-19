using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Application.Services.Individual;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.Individual.IndividualQuery
{
    public class IndividualGetQueryHandler:IRequestHandler<IndividualGetQuery,IndividualGetModel>
    {
        private readonly ETContext _context;
        private readonly IMapper _mapper;
        private readonly IIndividualRepository _individualRepository;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndividualGetQueryHandler(ETContext context, IMapper mapper, IIndividualRepository individualRepository, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _individualRepository = individualRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IndividualGetModel> Handle(IndividualGetQuery request, CancellationToken cancellationToken)
        {
            User usr = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var individual = await _context.Individuals.Include(s=>s.Occupation).FirstOrDefaultAsync(x=>x.IndividualId==request.Id,cancellationToken);
            if (individual == null) throw new NotFoundException("Individual", request.Id);

            //check logged in user is same as request passed individual id
            IndividualSecurity.CheckIndividualAccessibleByCurrentUser(request.Id, usr, _individualRepository);
            var individualGetModel = _mapper.Map<IndividualGetModel>(individual);
            return individualGetModel;
        }
    }
}
