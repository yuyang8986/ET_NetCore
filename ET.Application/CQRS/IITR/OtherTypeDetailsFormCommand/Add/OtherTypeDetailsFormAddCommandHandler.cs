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

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Add
{
    public class OtherItemTypeDetailsFormAddCommandHandler : IRequestHandler<OtherItemTypeDetailsFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public OtherItemTypeDetailsFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(OtherItemTypeDetailsFormAddCommand request, CancellationToken cancellationToken)
        {
            List<OtherItemTypeDetail> otherItemTypeDetails = request.OtherTypeDetails;
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.OtherItemTypeDetails.AddRangeAsync(otherItemTypeDetails, cancellationToken);
                    if (await _context.SaveChangesAsync(cancellationToken) < 1)
                        throw new ChildFormSaveException(nameof(OtherItemTypeDetail), request.MainFormId);
                    
                    await _context.OtherItemDetailsForms.AddAsync(
                        new OtherItemDetailsForm { MainFormId = request.MainFormId, OtherItemTypeDetails = otherItemTypeDetails },
                        cancellationToken);

                    if (await _context.SaveChangesAsync(cancellationToken) < 1)
                        throw new ChildFormSaveException(nameof(OtherItemDetailsForm), request.MainFormId);

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
