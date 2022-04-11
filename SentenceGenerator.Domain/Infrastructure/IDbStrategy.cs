using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator.Domain.Infrastructure
{
    public interface IDbStrategy
    {
        IDbConnection GetConnection(string connectionString);
    }
}
