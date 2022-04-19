using System;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Add
{
    public class OtherTypesFormAddCommandHandler : IRequestHandler<OtherTypesFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public OtherTypesFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(OtherTypesFormAddCommand request, CancellationToken cancellationToken)
        {
            if (request.OtherTypeIds.Count > 0)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        OtherItemTypeForm otherTypeForm = new OtherItemTypeForm(request.MainFormId);

                        _context.OtherItemTypeForms.Add(otherTypeForm);
                        if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(OtherItemTypeForm), request.MainFormId);

                        foreach (var otherTypeId in request.OtherTypeIds)
                        {
                            //add new joint table OthertypeOthertypesform data
                            var otherType = await _context.OtherItemTypes.FindAsync(otherTypeId);
                            if (otherType != null)
                            {
                                _context.OtherItemTypeOtherItemTypeForms.Add(new OtherItemTypeOtherItemForm
                                {
                                    OtherItemTypeId = otherTypeId,
                                    OtherItemTypeFormId = otherTypeForm.Id
                                });
                            }
                        }

                        if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(OtherItemTypeForm), request.MainFormId);
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
