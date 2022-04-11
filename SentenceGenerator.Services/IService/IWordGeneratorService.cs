using SentenceGenerator.Domain.Entities;
using SentenceGenerator.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Services.IService
{
    public interface IWordGeneratorService
    {
        Task<List<Words>> GetWords(string type);
    }
}
