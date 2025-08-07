using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.DIP
{
    // High-level module depends on the abstraction, not the concrete implementation.
    public class ReportGenerator
    {
        private readonly IReportExporter _exporter;

        // Dependency Injection via constructor
        public ReportGenerator(IReportExporter exporter)
        {
            _exporter = exporter;
        }

        public void GenerateAndExportReport(string reportData)
        {
            Console.WriteLine("Generating report data...");
            // Business logic to generate data
            _exporter.Export(reportData);
        }
    }
}
