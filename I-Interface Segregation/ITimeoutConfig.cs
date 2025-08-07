using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// Small, specific interface for timeout configuration
    /// ITimeoutConfig: For timeout settings.
    /// </summary>
    public interface ITimeoutConfig
    {
        int GetTimeoutInSeconds();
    }
}
