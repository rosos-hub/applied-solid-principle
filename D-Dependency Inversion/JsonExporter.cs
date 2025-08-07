using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.DIP
{
    // Another low-level module, also depending on the abstraction.
    public class JsonExporter : IReportExporter
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to JSON format...");
            // Logic to write to a JSON file
        }
    }
}
