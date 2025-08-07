using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// Small, specific interface for API configuration
    /// IApiConfig: For API-related settings.
    /// </summary>
    public interface IApiConfig
    {
        string GetApiEndpoint();
    }
}
