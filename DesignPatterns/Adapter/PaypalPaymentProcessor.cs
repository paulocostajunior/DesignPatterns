using System;
namespace DesignPatterns.Adapter
{
	public class PaypalPaymentProcessor : IPaymentProcessor
	{
        public void Process(decimal amount)
        {
            Console.WriteLine($"Paypal Processing {amount}");
        }
    }
}

