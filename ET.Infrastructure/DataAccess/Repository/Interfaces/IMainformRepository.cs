using System.Collections.Generic;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;

namespace ET.Infrastructure.DataAccess.Repository.Interfaces
{
    public interface IMainformRepository
    {
        void Add<T>(T entity) where T : class;
        Task<MainForm> Get(int id);
        Task<List<MainForm>> Get();
        Task<bool> SaveAll();
    }
}