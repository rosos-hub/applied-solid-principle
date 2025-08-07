using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.LSP
{
    /// <summary>
    /// We create a common abstract class, Transaction, which defines a clear contract (Process).
    /// </summary>
    public abstract class Transaction
    {
        // A clear contract that returns true/false for success/failure.
        public abstract bool Process(decimal amount);
    }
}
