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
    public class WithdrawalTransaction : Transaction
    {
        private decimal _accountBalance;

        public WithdrawalTransaction(decimal initialBalance)
        {
            _accountBalance = initialBalance;
        }

        public override bool Process(decimal amount)
        {
            if (amount > _accountBalance)
            {
                Console.WriteLine("Transaction failed: Not enough funds in the account.");
                return false;
            }
            _accountBalance -= amount;
            Console.WriteLine($"Withdrawing {amount:C}. New balance is {_accountBalance:C}.");
            return true;
        }
    }
}
