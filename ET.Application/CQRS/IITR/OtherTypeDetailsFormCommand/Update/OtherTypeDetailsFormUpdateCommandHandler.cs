using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Update
{
    public class OtherItemTypeDetailsFormUpdateCommandHandler:IRequestHandler<OtherTypeDetailsFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;
        private readonly IMapper _mapper;

        public OtherItemTypeDetailsFormUpdateCommandHandler(ETContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(OtherTypeDetailsFormUpdateCommand request, CancellationToken cancellationToken)
        {
            //VERY IMPORTANT, this PROCESS IS TO UPDATE EACH ITEM, NOT THE FORM OR OtherItem TYPE DETAILS
            //checking OtherItemDetailsForm existing or not only
            OtherItemDetailsForm otherItemDetailsForm =
                await _context.OtherItemDetailsForms.AsNoTracking().Include(s=>s.OtherItemTypeDetails).FirstOrDefaultAsync(x=>x.Id == request.OtherDetailsFormId, cancellationToken);

            if(otherItemDetailsForm == null) throw new NotFoundException(nameof(OtherItemDetailsForm), request.OtherDetailsFormId);

            _mapper.Map(request, otherItemDetailsForm);


            _context.OtherItemDetailsForms.Update(otherItemDetailsForm);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
               throw new Exception(e.InnerException.Message);
            }
           

            return Unit.Value;
        }
    }
}
