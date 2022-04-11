using SentenceGenerator.DataAccess.EFCore.Settings;
using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.DataAccess.EFCore.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseSettings dbSettings)
            : base(dbSettings) { }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await DeleteAsync(id);
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await FindByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await FindAllAsync();
        }

        public async Task<bool> InsertUserAsync(User user)
        {
            return await CreateAsync(user);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await UpdateAsync(user);
        }
    }
}
