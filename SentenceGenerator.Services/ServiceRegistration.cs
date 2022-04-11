using Microsoft.Extensions.DependencyInjection;
using SentenceGenerator.Services.IService;
using SentenceGenerator.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISentenceService, SentenceService>();
            services.AddTransient<IWordGeneratorService, WordGeneratorService>();
            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
