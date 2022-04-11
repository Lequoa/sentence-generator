using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.UnitOfWork;
using SentenceGenerator.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.Service
{
    public class SentenceService : ISentenceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SentenceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddSentenceAsync(Sentence sentence)
        {
            return await _unitOfWork.Sentences.AddSentenceAsync(sentence);
        }

        public async Task<bool> DeleteSentenceAsync(int id)
        {
            return await _unitOfWork.Sentences.DeleteSentenceAsync(id);
        }

        public async Task<Sentence> GetSentenceAsync(int id)
        {
            return await _unitOfWork.Sentences.GetSentenceAsync(id);
        }

        public async Task<IEnumerable<Sentence>> GetSentencesAsync()
        {
            return await _unitOfWork.Sentences.GetSentencesAsync();
        }

        public async Task<bool> UpdateSentenceAsync(Sentence sentence)
        {
            return await _unitOfWork.Sentences.UpdateSentenceAsync(sentence);
        }
    }
}
