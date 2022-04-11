using SentenceGenerator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Domain.Repositories
{
    public interface ISentenceRepository : IBaseRepository<Sentence>
    {
        Task<IEnumerable<Sentence>> GetSentencesAsync();
        Task<Sentence> GetSentenceAsync(int id);
        Task<bool> AddSentenceAsync(Sentence sentence);
        Task<bool> UpdateSentenceAsync(Sentence sentence);
        Task<bool> DeleteSentenceAsync(int id);
    }
}
