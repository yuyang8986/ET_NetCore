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

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand
{
    public class IncomeTypeDetailsFormUpdateCommandHandler:IRequestHandler<IncomeTypeDetailsFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;
        private readonly IMapper _mapper;

        public IncomeTypeDetailsFormUpdateCommandHandler(ETContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(IncomeTypeDetailsFormUpdateCommand request, CancellationToken cancellationToken)
        {
            //VERY IMPORTANT, this PROCESS IS TO UPDATE EACH ITEM, NOT THE FORM OR INCOME TYPE DETAILS
            //checking incomeDetailsForm existing or not only
            IncomeDetailsForm incomeDetailsForm =
                await _context.IncomeDetailsForms.AsNoTracking().Include(s=>s.IncomeTypeDetails).FirstOrDefaultAsync(x=>x.Id == request.IncomeDetailsFormId, cancellationToken);

            if(incomeDetailsForm == null) throw new NotFoundException(nameof(IncomeDetailsForm), request.IncomeDetailsFormId);

            _mapper.Map(request, incomeDetailsForm);
            _context.IncomeDetailsForms.Update(incomeDetailsForm);

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
