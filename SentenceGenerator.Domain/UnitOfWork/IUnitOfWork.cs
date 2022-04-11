using SentenceGenerator.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        ISentenceRepository Sentences { get;  }
        IUserRepository Users { get;  }
    }
}
