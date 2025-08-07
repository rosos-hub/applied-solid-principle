using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// A different client can depend on a different interface
    /// </summary>
    public class ApiClient
    {
        private readonly IApiConfig _config;

        public ApiClient(IApiConfig config)
        {
            _config = config;
        }

        public void CallApi()
        {
            string endpoint = _config.GetApiEndpoint();
            Console.WriteLine($"Calling API endpoint: {endpoint}");
        }
    }
}
