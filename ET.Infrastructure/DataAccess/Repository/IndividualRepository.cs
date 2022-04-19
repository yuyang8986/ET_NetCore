using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.DataAccess.Repository
{
    public class IndividualRepository:IIndividualRepository
    {
        private readonly ETContext _context;

        public IndividualRepository(ETContext context)
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

        public async Task<IEnumerable<Individual>> GetIndividuals()
        {
            var users = await _context.Individuals.Include(x => x.Lodgements).ToListAsync();
            return users;
        }

        public async Task<Individual> GetIndividualById(int individualId)
        {
            var individual = await _context.Individuals.Include(x => x.Lodgements).ThenInclude(x=>x.FinancialYear).FirstOrDefaultAsync(i => i.IndividualId == individualId);
            return individual;
        }

        public async Task<IEnumerable<Individual>> GetIndividualsByBusinessAccountUser(User user)
        {
            var individuals = await _context.Individuals.Include(x => x.Lodgements).ThenInclude(s=>s.FinancialYear)
                .Where(s => s.AccountUserId == user.Id).ToListAsync();
            return individuals;
        }

        public async Task<Individual> GetIndividualByIndividualAccountUser(User user)
        {
            var individual = await _context.Individuals.Include(x => x.Lodgements).ThenInclude(s=>s.FinancialYear)
                .Where(s => s.AccountUserId == user.Id).FirstOrDefaultAsync();
            return individual;
        }
    }
}
