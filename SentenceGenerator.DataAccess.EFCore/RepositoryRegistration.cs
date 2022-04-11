using Microsoft.Extensions.DependencyInjection;
using SentenceGenerator.DataAccess.EFCore.Repository;
using SentenceGenerator.Domain.Repositories;
using SentenceGenerator.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.DataAccess.EFCore
{
    public static class RepositoryRegistration
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISentenceRepository, SentenceRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
