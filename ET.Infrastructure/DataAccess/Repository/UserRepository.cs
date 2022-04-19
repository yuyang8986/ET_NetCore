using System;
using System.Threading.Tasks;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.DataAccess.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly ETContext _context;

        public UserRepository(ETContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _context.Users.Include(x => x.Individuals).FirstOrDefaultAsync(a => a.Id == id);
            return user;
        }

        public Task<User> GetUserByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
