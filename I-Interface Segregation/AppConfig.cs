using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// A single configuration class can implement all interfaces
    /// </summary>
    public class AppConfig : IDatabaseConfig, IApiConfig, ITimeoutConfig
    {
        public string GetDatabaseConnectionString()
        {
            return "Server=myServer;Database=myDataBase;...";
        }

        public string GetApiEndpoint()
        {
            return "https://api.example.com/v1";
        }

        public int GetTimeoutInSeconds()
        {
            return 30;
        }
    }
}
