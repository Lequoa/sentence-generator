using SentenceGenerator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.IService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<bool> AddUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> RemoveUser(int id);
    }
}
