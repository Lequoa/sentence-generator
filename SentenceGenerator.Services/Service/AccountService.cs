using SentenceGenerator.Domain.Helpers;
using SentenceGenerator.Domain.UnitOfWork;
using SentenceGenerator.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Login(string email, string password)
        {
            string hashedPassword = Crypto.Encrypt(password);
            var users = await _unitOfWork.Users.FindAllAsync();
            var user = users.Where(x => x.Email == email && x.Password == hashedPassword);

            return user != null;
        }
    }
}
