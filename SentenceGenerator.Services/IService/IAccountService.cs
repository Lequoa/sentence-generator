using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.IService
{
    public interface IAccountService
    {
        Task<bool> Login(string email, string password);
    }
}
