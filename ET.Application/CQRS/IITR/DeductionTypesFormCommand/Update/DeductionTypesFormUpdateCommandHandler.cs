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

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Update
{
    public class DeductionTypesFormUpdateCommandHandler : IRequestHandler<DeductionTypesFormUpdateCommand, Unit>
    {
        private readonly ETContext _context;

        public DeductionTypesFormUpdateCommandHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeductionTypesFormUpdateCommand request, CancellationToken cancellationToken)
        {
            DeductionTypeForm deductionTypeForm = await _context.DeductionTypeForms.FindAsync(request.Id);
            
            if (request.DeductionTypeIds.Count > 0)
            {
                //find joint DeductiontypeDeductiontypesform data and remove
                var deductionTypesDeductionTypesFormToRemove = await _context.DeductionTypeDeductionTypeForms
                    .Where(s => s.DeductionTypeFormId == deductionTypeForm.Id).ToListAsync(cancellationToken);

                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.DeductionTypeDeductionTypeForms.RemoveRange(deductionTypesDeductionTypesFormToRemove);
                        _context.SaveChanges();

                        //add new ones
                        foreach (var deductionTypeId in request.DeductionTypeIds)
                        {
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
