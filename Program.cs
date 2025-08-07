using System;

namespace AppliedSOLIDPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP - Usage
            //Each responsibility is now its own class, with a single reason to change.
            Console.WriteLine("------------------SRP--------------------");

            var orderValidator = new SRP.OrderValidator();
            var orderRepository = new SRP.OrderRepository();
            var emailService = new SRP.EmailService();

            var orderService = new SRP.OrderService(orderValidator, orderRepository, emailService);

            var orderModel = new SRP.OrderModel()
            {
                ID = 1,
                CustomerName = "Jose Rizal",
                CustomerEmail = "Jose.Rizal@mail.com"
            };

            orderService.ProcessOrder(orderModel);

            #endregion

            #region OCP - Usage
            Console.WriteLine("------------------OCP--------------------");

            var paymentProcessor = new OCP.PaymentProcessor();

            // The processor can handle any object that implements IPaymentMethod
            OCP.IPaymentMethod cash = new OCP.CashPayment();
            OCP.IPaymentMethod creditCard = new OCP.CreditCardPayment()
            { 
                CreditCardNumber = 5643452687 
            };

            paymentProcessor.Process(cash, 500.75m);
            paymentProcessor.Process(creditCard, 1000.50m);

            #endregion

            #region LSP - Usage
            Console.WriteLine("------------------LSP--------------------");

            var processor = new LSP.TransactionProcessor();

            LSP.Transaction deposit = new LSP.DepositTransaction();
            processor.Process(deposit, 500m);

            LSP.Transaction withdrawal = new LSP.WithdrawalTransaction(200m);
            processor.Process(withdrawal, 150m);
            processor.Process(withdrawal, 300m);

            #endregion

            #region ISP - Usage
            Console.WriteLine("------------------ISP--------------------");

            var config = new ISP.AppConfig();

            var dbClient = new ISP.DatabaseClient(config);
            dbClient.Connect();

            var apiClient = new ISP.ApiClient(config);
            apiClient.CallApi();

      
            config.GetTimeoutInSeconds();

            #endregion

            #region DIP - Usage
            Console.WriteLine("------------------DIP--------------------");

            // We can inject different exporters without changing ReportGenerator.
            DIP.IReportExporter csvExporter = new DIP.CsvExporter();
            var csvReportGenerator = new DIP.ReportGenerator(csvExporter);
            csvReportGenerator.GenerateAndExportReport("Report 1 data");

            DIP.IReportExporter jsonExporter = new DIP.JsonExporter();
            var jsonReportGenerator = new DIP.ReportGenerator(jsonExporter);
            jsonReportGenerator.GenerateAndExportReport("Report 2 data");
            #endregion
        }
    }
}