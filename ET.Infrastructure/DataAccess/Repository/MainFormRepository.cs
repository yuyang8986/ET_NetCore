using System.Collections.Generic;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.DataAccess.Repository
{
    public class MainFormRepository:IMainformRepository
    {
        private readonly ETContext _context;

        public MainFormRepository(ETContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<MainForm> Get(int id)
        {
            var mainForm = await _context.MainForms
                .Include(s=>s.BasicDetailsForm)
                .Include(s=>s.IITRLodgement).ThenInclude(s=>s.Individual)
                .Include(s => s.IITRLodgement).ThenInclude(s => s.FinancialYear)
                .Include(s => s.BasicDetailsForm)
                .Include(s => s.DeductionDetailsForm).ThenInclude(x=>x.DeductionTypeDetails)
                .Include(s => s.DeductionTypeForm).ThenInclude(x => x.DeductionTypeDeductionTypeForms).ThenInclude(x => x.DeductionType)
                .Include(s => s.IncomeDetailsForm).ThenInclude(x=>x.IncomeTypeDetails)
                .Include(s => s.IncomeTypeForm).ThenInclude(x=>x.IncomeTypeIncomeTypeForms).ThenInclude(x=>x.IncomeType)
                .Include(s => s.OtherItemDetailsForm).ThenInclude(x=>x.OtherItemTypeDetails)
                .Include(s => s.OtherItemTypeForm).ThenInclude(x=>x.OtherItemTypeOtherItemForms).ThenInclude(a=>a.OtherItemType)
                .FirstOrDefaultAsync(x=>x.Id == id);
            return mainForm;
        }

        public async Task<List<MainForm>> Get()
        {
            var mainForms = await _context.MainForms
                .Include(s => s.BasicDetailsForm)
                .Include(s => s.IITRLodgement).ThenInclude(s => s.FinancialYear)
                .Include(s => s.BasicDetailsForm)
                .Include(s => s.DeductionDetailsForm).ThenInclude(x => x.DeductionTypeDetails)
                .Include(s => s.DeductionTypeForm).ThenInclude(x => x.DeductionTypeDeductionTypeForms).ThenInclude(x => x.DeductionType)
                .Include(s => s.IncomeDetailsForm).ThenInclude(x => x.IncomeTypeDetails).ThenInclude(a => a.PaygSummaries)
                .Include(s => s.IncomeTypeForm).ThenInclude(x => x.IncomeTypeIncomeTypeForms).ThenInclude(x => x.IncomeType)
                .Include(s => s.OtherItemDetailsForm).ThenInclude(x => x.OtherItemTypeDetails)
                .Include(s => s.OtherItemTypeForm).ThenInclude(x => x.OtherItemTypeOtherItemForms).ThenInclude(a => a.OtherItemType)
                .ToListAsync();

            return mainForms;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
