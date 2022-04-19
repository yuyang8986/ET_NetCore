using System.Collections.Generic;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Auth;

namespace ET.Infrastructure.DataAccess.Repository.Interfaces
{
    public interface IIndividualRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<Individual>> GetIndividuals();
        Task<Individual> GetIndividualById(int individualId);
        Task<Individual> GetIndividualByIndividualAccountUser(User user);
    }
}