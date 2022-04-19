using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IITR.BasicDetailsFormCommand.Update
{
    public class BasicDetailsFormUpdateCommandHandler : IRequestHandler<BasicDetailsFormUpdateCommand>
    {
        private readonly IMapper _mapper;
        private readonly ETContext _context;
      

        public BasicDetailsFormUpdateCommandHandler(IMapper mapper,ETContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<Unit> Handle(BasicDetailsFormUpdateCommand request, CancellationToken cancellationToken)
        {

            BasicDetailsForm basicDetailsForm = await _context.BasicDetailsForms.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken: cancellationToken);
            _mapper.Map(request,basicDetailsForm);
            _context.BasicDetailsForms.Update(basicDetailsForm);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
