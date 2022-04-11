using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SentenceGenerator.Services.IService;
using SentenceGenerator.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.Controllers
{
    [ApiController]
    [Route("[api/word]")]
    public class WordGeneratorController : ControllerBase
    {
        private readonly IWordGeneratorService _wordGenerator;

        private readonly ILogger<WordGeneratorController> _logger;

        public WordGeneratorController(ILogger<WordGeneratorController> logger, IWordGeneratorService wordGenerator)
        {
            _logger = logger;
            _wordGenerator = wordGenerator;
        }

        [HttpGet]
        public async Task<List<Words>> Get(string type)
        {
            var result = await _wordGenerator.GetWords(type);

            return result;
        }
    }
}
