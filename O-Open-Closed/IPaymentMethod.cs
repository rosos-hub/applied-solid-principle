using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.OCP
{
    /// <summary>
    /// Abstraction: All payment methods must implement this interface
    /// An IPaymentMethod interface is created, which defines a ProcessPayment method. 
    /// This sets a contract for all payment methods.
    /// </summary>
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }
}
