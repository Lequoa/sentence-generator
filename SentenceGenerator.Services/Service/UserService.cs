using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.Helpers;
using SentenceGenerator.Domain.Repositories;
using SentenceGenerator.Domain.UnitOfWork;
using SentenceGenerator.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddUser(User user) {
            Crypto.Encrypt(user.Password);
            return await _unitOfWork.Users.CreateAsync(user);
        }

        public async Task<User> GetUser(int id) {

            return await _unitOfWork.Users.GetUserAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsers() {
            return await _unitOfWork.Users.GetUsersAsync();
        }

        public async Task<bool> RemoveUser(int id) {
            return await _unitOfWork.Users.DeleteAsync(id);
        }

        public async Task<bool> UpdateUser(User user) {
            return await _unitOfWork.Users.UpdateAsync(user);
        }
    }
}
