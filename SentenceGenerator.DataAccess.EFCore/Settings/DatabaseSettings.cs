using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceGenerator.DataAccess.EFCore.Settings
{
    public class DatabaseSettings
    {
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
    }
}
