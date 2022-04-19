using System;
using System.Threading;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.Exceptions;
using MediatR;

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Add
{
    public class IncomeTypesFormAddCommandHandler : IRequestHandler<IncomeTypesFormAddCommand, Unit>
    {
        private readonly ETContext _context;

        public IncomeTypesFormAddCommandHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(IncomeTypesFormAddCommand request, CancellationToken cancellationToken)
        {
            if (request.IncomeTypeIds.Count > 0)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        IncomeTypeForm incomeTypeForm = new IncomeTypeForm(request.MainFormId);

                        _context.IncomeTypeForms.Add(incomeTypeForm);
                        if (await _context.SaveChangesAsync(cancellationToken) < 1)
                            throw new ChildFormSaveException(nameof(IncomeTypeForm), request.MainFormId);

                        foreach (var incomeTypeId in request.IncomeTypeIds)
                        {
                            //add new joint table incometypeincometypesform data
                            var incomeType = await _context.IncomeTypes.FindAsync(incomeTypeId);
                            if (incomeType != null)
                            {
                                _context.IncomeTypeIncomeTypeForms.Add(new IncomeTypeIncomeTypeForm
                                {
                                    IncomeTypeFormId = incomeTypeForm.Id,
                                    IncomeTypeId = incomeTypeId
                                });
                            }
                        }

                        if (await _context.SaveChangesAsync(cancellationToken) < 1)
                            throw new ChildFormSaveException(nameof(IncomeTypeForm), request.MainFormId);
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
