using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.OCP
{
    /// <summary>
    /// The core processor is now closed for modification
    /// The PaymentProcessor class is now closed for modification. 
    /// Its Process method takes any object that implements IPaymentMethod and simply calls its ProcessPayment method. 
    /// It doesn't need to know the specific type of payment; it just trusts that the object knows how to process itself.
    /// </summary>
    public class PaymentProcessor
    {
        public void Process(IPaymentMethod payment, decimal amount)
        {
            payment.ProcessPayment(amount);
        }
    }
}
