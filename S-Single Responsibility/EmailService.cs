using System;

namespace AppliedSOLIDPrinciple.SRP
{
    /// <summary>
    /// Single Responsibility: Sending Email
    /// This class is responsible for sending emails. 
    /// It will only change if the email provider or the method of sending emails changes.
    /// </summary>
    public class EmailService
    {
        public void Send(OrderModel orderModel)
        {
            // Code to send an email confirmation
            Console.WriteLine($"Confirmation email sent to {orderModel.CustomerEmail}.");
        }
    }
}
