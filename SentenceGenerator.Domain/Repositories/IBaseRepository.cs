using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IQueryable<T>> FindAllAsync();
        Task<T> FindByIdAsync(int id);
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
