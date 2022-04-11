using Microsoft.AspNetCore.Mvc;
using SentenceGenerator.Api.RequestModel;
using SentenceGenerator.Services.IService;
using System.Threading.Tasks;

namespace SentenceGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpPost]
        public async Task<bool> Login(LoginVewModel login)
        {
            return await _accountService.Login(login.Email, login.Password);
        }
    }
}
