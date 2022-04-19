using System.Collections.Generic;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.LodgementAggregate;

namespace ET.Infrastructure.DataAccess.Repository.Interfaces
{
    public interface IIITRLodgementRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<IITRLodgement>> GetLodgements();
        Task<IITRLodgement> GetLodgementById(int lodgementId);
        Task<IEnumerable<IITRLodgement>> GetLodgementByIndividual(Individual individual);
    }
}