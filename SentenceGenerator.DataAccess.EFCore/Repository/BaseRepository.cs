using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using SentenceGenerator.DataAccess.EFCore.Infrastructure;
using SentenceGenerator.DataAccess.EFCore.Settings;
using SentenceGenerator.Domain.Repositories;


namespace SentenceGenerator.DataAccess.EFCore.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected IDbConnection connection { get; private set; }
        private readonly DatabaseSettings _dbSettings;

        public BaseRepository(DatabaseSettings databaseSettings)
        {
            _dbSettings = databaseSettings;
            connection = new DbContext().SetStrategy(_dbSettings.ProviderName).GetDbContext(_dbSettings.ConnectionString);
        }

        public async Task<IQueryable<T>> FindAllAsync()
        {
            connection.Open();

            try
            {
                var result = await connection.GetAllAsync<T>();
                return result.AsQueryable();
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<T> FindByIdAsync(int id)
        {
            connection.Open();

            try
            {
                return await connection.GetAsync<T>(id);
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<bool> CreateAsync(T entity)
        {
            connection.Open();

            try
            {
                var inserted = await connection.InsertAsync<T>(entity);

                return inserted != 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            connection.Open();

            try
            {
                return await connection.UpdateAsync<T>(entity);
            }
            finally
            {

            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            connection.Open();

            try
            {
                var entity = await connection.GetAsync<T>(id);

                if (entity == null)
                    return false;
                return await connection.DeleteAsync<T>(entity);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
