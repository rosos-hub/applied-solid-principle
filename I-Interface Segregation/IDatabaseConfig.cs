using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.ISP
{
    /// <summary>
    /// Small, specific interface for database configuration
    /// IDatabaseConfig: For database-related settings.
    /// </summary>
    public interface IDatabaseConfig
    {
        string GetDatabaseConnectionString();
    }
}
