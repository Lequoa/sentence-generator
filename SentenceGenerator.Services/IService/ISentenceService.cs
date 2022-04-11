using SentenceGenerator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.IService
{
    public interface ISentenceService
    {
        Task<IEnumerable<Sentence>> GetSentencesAsync();
        Task<Sentence> GetSentenceAsync(int id);
        Task<bool> AddSentenceAsync(Sentence user);
        Task<bool> UpdateSentenceAsync(Sentence user);
        Task<bool> DeleteSentenceAsync(int id);
    }
}
