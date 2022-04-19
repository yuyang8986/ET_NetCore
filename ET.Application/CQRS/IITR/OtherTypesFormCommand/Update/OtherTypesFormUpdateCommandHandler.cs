using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Update
{
    public class OtherItemTypesFormUpdateCommandHandler : IRequestHandler<OtherTypesFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;

        public OtherItemTypesFormUpdateCommandHandler(ETContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(OtherTypesFormUpdateCommand request, CancellationToken cancellationToken)
        {
            OtherItemTypeForm otherItemTypeForm = await _context.OtherItemTypeForms.FindAsync(request.Id);

            if (request.OtherTypeIds.Count > 0)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        //find joint OtherItemtypeOtherItemtypesform data and remove
                        var otherItemTypesOtherItemTypesFormToRemove = await _context.OtherItemTypeOtherItemTypeForms
                            .Where(s => s.OtherItemTypeFormId == otherItemTypeForm.Id).ToListAsync(cancellationToken);

                        _context.OtherItemTypeOtherItemTypeForms.RemoveRange(otherItemTypesOtherItemTypesFormToRemove);
                        _context.SaveChanges();

                        //add new ones
                        foreach (var otherItemTypeId in request.OtherTypeIds)
                        {
                            var otherItemType = await _context.OtherItemTypes.FindAsync(otherItemTypeId);
                            if (otherItemType != null)
                            {
                                _context.OtherItemTypeOtherItemTypeForms.Add(new OtherItemTypeOtherItemForm
                                {
                                    OtherItemTypeFormId = otherItemTypeForm.Id,
                                    OtherItemTypeId = otherItemTypeId
                                });
                            }
                        }

                        await _context.SaveChangesAsync(cancellationToken);
                        dbContextTransaction.Commit();
                    }

                    catch (Exception e)
                    {
                        throw new Exception(e.InnerException.Message);
                    }
                }
            }
            return Unit.Value;
        }
    }
}
