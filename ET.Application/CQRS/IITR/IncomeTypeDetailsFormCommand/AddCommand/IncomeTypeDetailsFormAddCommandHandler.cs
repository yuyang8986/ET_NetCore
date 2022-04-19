using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.AddCommand
{
    public class IncomeTypeDetailsFormAddCommandHandler:IRequestHandler<IncomeTypeDetailsFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public IncomeTypeDetailsFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(IncomeTypeDetailsFormAddCommand request, CancellationToken cancellationToken)
        {
            List<IncomeTypeDetail> incomeTypeDetails = request.IncomeTypeDetails;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.IncomeTypeDetails.AddRangeAsync(incomeTypeDetails, cancellationToken);
                    if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(IncomeTypeDetail), request.MainFormId);

                    await _context.IncomeDetailsForms.AddAsync(
                        new IncomeDetailsForm { MainFormId = request.MainFormId, IncomeTypeDetails = incomeTypeDetails },
                        cancellationToken);

                    if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(IncomeDetailsForm), request.MainFormId);

                    dbContextTransaction.Commit();
                }
                catch (Exception e)
                {
                    throw new Exception(e.InnerException.Message);
                }
            }
               
            return Unit.Value;
        }
    }
}
