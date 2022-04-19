using System;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Add
{
    public class DeductionTypesFormAddCommandHandler : IRequestHandler<DeductionTypesFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public DeductionTypesFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeductionTypesFormAddCommand request, CancellationToken cancellationToken)
        {
            if (request.DeductionTypeIds.Count > 0)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        DeductionTypeForm deductionTypeForm = new DeductionTypeForm(request.MainFormId);

                        _context.DeductionTypeForms.Add(deductionTypeForm);
                        _context.SaveChanges();

                        foreach (var deductionTypeId in request.DeductionTypeIds)
                        {
                            //add new joint table DeductiontypeDeductiontypesform data
                            var deductionType = await _context.DeductionTypes.FindAsync(deductionTypeId);
                            if (deductionType != null)
                            {
                                _context.DeductionTypeDeductionTypeForms.Add(new DeductionTypeDeductionTypeForm
                                {
                                    DeductionTypeFormId = deductionTypeForm.Id,
                                    DeductionTypeId = deductionTypeId
                                });
                            }
                        }

                        if (await _context.SaveChangesAsync(cancellationToken) < 1) throw new ChildFormSaveException(nameof(DeductionTypeForm), request.MainFormId);


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
