using Microsoft.AspNetCore.Mvc;
using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Domain.UnitOfWork;
using SentenceGenerator.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/sentence")]
    public class SentenceController : Controller
    {
        private readonly ISentenceService _sentenceService;

        public SentenceController(ISentenceService sentenceService) {
            _sentenceService = sentenceService;
        }

        [HttpGet]
        public async Task<List<Sentence>> Get()
        {
            var users = await _sentenceService.GetSentencesAsync();

            return users.ToList();
        }

        [HttpPost]
        public async Task<bool> Save(Sentence sentence)
        {
            sentence.UserId = 1;
            return  await _sentenceService.AddSentenceAsync(sentence);
        }

        
    }
}
