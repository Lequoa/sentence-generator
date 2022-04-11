using SentenceGenerator.Domain.Repositories;
using SentenceGenerator.Domain.UnitOfWork;

namespace SentenceGenerator.DataAccess.EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        public ISentenceRepository Sentences { get; }
        public IUserRepository Users { get; }

        public UnitOfWork(ISentenceRepository sentenceRepository, IUserRepository userRepository)
        {
            Sentences = sentenceRepository;
            Users = userRepository;
        }
    }
}
