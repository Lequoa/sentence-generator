using Microsoft.AspNetCore.Mvc;
using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.UnitOfWork;
using SentenceGenerator.Services.IService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            var users = await _userService.GetUsers();

            return users.ToList();
        }

        [HttpPost]
        public async Task<bool> SaveUser(User user)
        {
            return await _userService.AddUser(user);
        }
    }
}
