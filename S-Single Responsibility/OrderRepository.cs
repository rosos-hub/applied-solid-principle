using System;

namespace AppliedSOLIDPrinciple.SRP
{
    /// <summary>
    /// Single Responsibility: Data Persistence (saving the order to database)
    /// This class handles all data access operations, such as saving the order. 
    /// It will only change if the database or the way data is persisted changes.
    /// </summary>
    public class OrderRepository
    {
        public OrderRepository() { }
            
        public void Save(OrderModel orderModel) {
            // Code to save the order to a database
            Console.WriteLine($"Order for {orderModel.CustomerName} saved to database.");
        }
    }
}
