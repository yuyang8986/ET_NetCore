using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.DataAccess.Repository
{
    public class IITRLodgementRepository : IIITRLodgementRepository
    {
        private readonly ETContext _context;

        public IITRLodgementRepository(ETContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<IITRLodgement>> GetLodgements()
        {
            var lodgements = await _context.IITRLodgements.ToListAsync();
            return lodgements;
        }

        public async Task<IITRLodgement> GetLodgementById(int lodgementId)
        {
            var lodgement = await _context.IITRLodgements.Include(s=>s.MainForm).Include(lll=>lll.FinancialYear).FirstOrDefaultAsync(i => i.IITRLodgementId == lodgementId);
            return lodgement;
        }

        public async Task<IEnumerable<IITRLodgement>> GetLodgementByIndividual(Individual individual)
        {
            var lodgement = await _context.IITRLodgements.Include(s => s.MainForm).Include(lll => lll.FinancialYear).Where(x => x.IndividualId == individual.IndividualId).ToListAsync();
            return lodgement;
        }
    }
}
