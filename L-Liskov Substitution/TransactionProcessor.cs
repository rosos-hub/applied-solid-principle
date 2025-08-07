using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.LSP
{
    /// <summary>
    /// The TransactionProcessor can now handle both successful and failed transactions gracefully.
    /// The subclass (WithdrawalTransaction, DepositTransaction) is a valid substitute for the base class (Transaction)
    /// because it fulfills the core contract without surprising the client.
    /// </summary>
    public class TransactionProcessor
    {
        public void Process(Transaction transaction, decimal amount)
        {
            // The processor can now handle the result without breaking.
            bool success = transaction.Process(amount);

            if (!success)
            {
                Console.WriteLine("The transaction was not successful.");
            }
        }
    }
}
