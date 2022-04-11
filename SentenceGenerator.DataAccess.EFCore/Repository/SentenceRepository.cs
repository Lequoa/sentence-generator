using SentenceGenerator.DataAccess.EFCore.Settings;
using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.DataAccess.EFCore.Repository
{
    public class SentenceRepository : BaseRepository<Sentence>, ISentenceRepository
    {
        public SentenceRepository(DatabaseSettings dbSettings)
            : base(dbSettings) { }

        public async Task<bool> AddSentenceAsync(Sentence sentence)
        {
            return await CreateAsync(sentence);
        }

        public async Task<bool> DeleteSentenceAsync(int id)
        {
            return await DeleteAsync(id);
        }

        public async Task<IEnumerable<Sentence>> GetSentencesAsync()
        {
            return await FindAllAsync();
        }

        public async Task<Sentence> GetSentenceAsync(int id)
        {
            return await FindByIdAsync(id);
        }

        public async Task<bool> UpdateSentenceAsync(Sentence sentence)
        {
            return await UpdateAsync(sentence);
        }
    }
}
