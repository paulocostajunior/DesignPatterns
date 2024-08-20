using System;
namespace DesignPatterns.Adapter
{
	public class StripePaymentService
	{
		public void MakePayment(decimal amount, string currency)
		{
			Console.WriteLine($"StripePayment service processing {amount}, {currency}");
		}
	}
}

