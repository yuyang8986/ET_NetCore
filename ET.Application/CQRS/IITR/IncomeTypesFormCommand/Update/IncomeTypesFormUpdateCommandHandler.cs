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

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Update
{
    public class IncomeTypesFormUpdateCommandHandler : IRequestHandler<IncomeTypesFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;

        public IncomeTypesFormUpdateCommandHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(IncomeTypesFormUpdateCommand request, CancellationToken cancellationToken)
        {
            IncomeTypeForm incomeTypeForm = await _context.IncomeTypeForms.FindAsync(request.Id);
            
            if (request.IncomeTypeIds.Count > 0)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        //find joint incometypeincometypesform data and remove
                        var incomeTypesIncomeTypesFormToRemove = await _context.IncomeTypeIncomeTypeForms
                            .Where(s => s.IncomeTypeFormId == incomeTypeForm.Id).ToListAsync(cancellationToken);

                        _context.IncomeTypeIncomeTypeForms.RemoveRange(incomeTypesIncomeTypesFormToRemove);
                        _context.SaveChanges();

                        //add new ones
                        foreach (var incomeTypeId in request.IncomeTypeIds)
                        {
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
