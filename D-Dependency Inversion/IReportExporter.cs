using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.DIP
{
    // Abstraction: high-level and low-level modules both depend on this.
    public interface IReportExporter
    {
        void Export(string data);
    }
}
