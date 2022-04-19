using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;

namespace ET.Application.CQRS.IITR.BasicDetailsFormCommand.Add
{
    public class BasicDetailsFormAddCommandHandler:IRequestHandler<BasicDetailsFormAddCommand>
    {
        private readonly IMapper _mapper;
        private readonly ETContext _context;
      

        public BasicDetailsFormAddCommandHandler(IMapper mapper,ETContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<Unit> Handle(BasicDetailsFormAddCommand request, CancellationToken cancellationToken)
        {
            BasicDetailsForm basicDetailsForm = _mapper.Map<BasicDetailsForm>(request);
            _context.BasicDetailsForms.Add(basicDetailsForm);
           
            if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(BasicDetailsForm), request.MainFormId);
            return Unit.Value;
        }
    }
}
