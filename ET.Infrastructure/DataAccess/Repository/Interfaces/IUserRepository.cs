using System.Threading.Tasks;
using ET.Domain.Entities.Auth;

namespace ET.Infrastructure.DataAccess.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByUserName(string username);
        Task<User> GetUserByEmail(string email);

    }
}