using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.DIP
{
    // Low-level module depends on the abstraction.
    public class CsvExporter : IReportExporter
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to CSV format...");
            // Logic to write to a CSV file
        }
    }
}
