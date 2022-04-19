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

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update
{
    public class DeductionTypeDetailsFormUpdateCommandHandler:IRequestHandler<DeductionTypeDetailsFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;
        private readonly IMapper _mapper;

        public DeductionTypeDetailsFormUpdateCommandHandler(ETContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeductionTypeDetailsFormUpdateCommand request, CancellationToken cancellationToken)
        {
            //VERY IMPORTANT, this PROCESS IS TO UPDATE EACH ITEM, NOT THE FORM OR Deduction TYPE DETAILS
            //checking DeductionDetailsForm existing or not only
            DeductionDetailsForm deductionDetailsForm =
                await _context.DeductionDetailsForms.AsNoTracking().Include(s=>s.DeductionTypeDetails).FirstOrDefaultAsync(x=>x.Id == request.DeductionDetailsFormId, cancellationToken);

            if(deductionDetailsForm == null) throw new NotFoundException(nameof(DeductionDetailsForm), request.DeductionDetailsFormId);

            _mapper.Map(request, deductionDetailsForm);
            _context.DeductionDetailsForms.Update(deductionDetailsForm);

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
