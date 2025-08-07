using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSOLIDPrinciple.LSP
{
    /// <summary>
    /// Each transaction type (DepositTransaction, WithdrawalTransaction) implements abstract class Transaction. 
    /// They are separate concrete classes, not in an invalid inheritance hierarchy.
    /// </summary>
    public class DepositTransaction : Transaction
    {
        public override bool Process(decimal amount)
        {
            Console.WriteLine($"Depositing {amount:C} to the account.");
            return true;
        }
    }
}
