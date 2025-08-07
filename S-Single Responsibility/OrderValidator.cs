using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.SRP
{
    /// <summary>
    /// Single Responsibility: Validating a Customer Order
    /// This class is now solely responsible for validation. 
    /// Its only reason to change is if the validation rules for an order change.
    /// </summary>
    public class OrderValidator
    {
        public bool Validate(OrderModel orderModel)
        {
            bool result = false;
            if (orderModel != null)
            {
                if (string.IsNullOrEmpty(orderModel.CustomerName))
                {
                    //throw new ArgumentException("Customer name cannot be empty.");
                    Console.WriteLine("Customer name cannot be empty.");
                }
                else if (string.IsNullOrEmpty(orderModel.CustomerEmail))
                {
                    //throw new ArgumentException("Customer email cannot be empty.");
                    Console.WriteLine("Customer email cannot be empty.");
                }
                else
                {
                    result = true;
                    Console.WriteLine($"Order for {orderModel.CustomerName} is validated.");
                }
            }
            else
            {
                //throw new InvalidOperationException("Invalid Operation");
                Console.WriteLine("Invalid Operation");
            }
            return result;
        }
    }
}
