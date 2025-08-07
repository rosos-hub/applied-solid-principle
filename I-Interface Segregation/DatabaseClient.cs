using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// The client now depends only on the interface it needs
    /// </summary>
    public class DatabaseClient
    {
        private readonly IDatabaseConfig _config;

        public DatabaseClient(IDatabaseConfig config)
        {
            _config = config;
        }

        public void Connect()
        {
            string connectionString = _config.GetDatabaseConnectionString();
            Console.WriteLine($"Connecting to database with: {connectionString}");
        }
    }
}
