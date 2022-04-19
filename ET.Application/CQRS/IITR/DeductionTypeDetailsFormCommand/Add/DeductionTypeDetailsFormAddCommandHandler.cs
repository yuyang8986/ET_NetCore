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

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Add
{
    public class DeductionTypeDetailsFormAddCommandHandler:IRequestHandler<DeductionTypeDetailsFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public DeductionTypeDetailsFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeductionTypeDetailsFormAddCommand request, CancellationToken cancellationToken)
        {
            List<DeductionTypeDetail> deductionTypeDetails = request.DeductionTypeDetails;

            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.DeductionTypeDetails.AddRangeAsync(deductionTypeDetails, cancellationToken);
                    if (await _context.SaveChangesAsync(cancellationToken) < 1)
                        throw new ChildFormSaveException(nameof(DeductionTypeDetail), request.MainFormId);

                    await _context.DeductionDetailsForms.AddAsync(new DeductionDetailsForm
                        {
                            MainFormId = request.MainFormId, DeductionTypeDetails = deductionTypeDetails
                        },
                        cancellationToken);

                    if (await _context.SaveChangesAsync(cancellationToken) < 1)
                        throw new ChildFormSaveException(nameof(DeductionDetailsForm), request.MainFormId);

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
