using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ET.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ET.Application.CQRS.IncomeTypesQuery.GetAll
{
    public class IncomeTypesGetAllQueryHandler:IRequestHandler<IncomeTypesGetAllQuery, IncomeTypesGetAllModel>
    {
        private readonly ETContext _context;

        public IncomeTypesGetAllQueryHandler(ETContext context)
        {
            _context = context;
        }
        public async Task<IncomeTypesGetAllModel> Handle(IncomeTypesGetAllQuery request, CancellationToken cancellationToken)
        {
            var incomeTypes = await _context.IncomeTypes.ToListAsync(cancellationToken);
            return new IncomeTypesGetAllModel(incomeTypes.ToList());   
   
        }
    }
}
