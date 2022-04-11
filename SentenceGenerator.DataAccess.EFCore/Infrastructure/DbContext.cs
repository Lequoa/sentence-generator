using SentenceGenerator.Domain.Infrastructure;
using System.Data;

namespace SentenceGenerator.DataAccess.EFCore.Infrastructure
{
    public class DbContext
    {
        private IDbStrategy _dbStrategy;

        public DbContext()
        {
        }

        public DbContext SetStrategy(string providerType)
        {
            _dbStrategy = providerType switch
            {
                "SqlServer" => _dbStrategy = new SqlServerStrategy(),
                _ => null
            };

            return this;
        }

        public IDbConnection GetDbContext(string connectionString)
        {
            return _dbStrategy.GetConnection(connectionString);
        }
    }
}
