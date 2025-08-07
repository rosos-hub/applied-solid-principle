using AppliedSOLIDPrinciple.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.OCP
{
    /// <summary>
    /// A concrete class for a Cash payment
    /// Each specific payment method (CreditCardPayment, CashPayment, etc.) is a separate class 
    /// that implements this interface, providing its own distinct processing logic.
    /// 
    /// To add a new payment method (e.g., ApplePayPayment), you simply create a new class that implements IPaymentMethod. 
    /// You never have to touch the PaymentProcessor class. 
    /// This makes the code open for extension without the risk of modifying existing, tested code.
    /// </summary>
    public class CashPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing cash payment of {amount:C}.");
        }
    }
}
