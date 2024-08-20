using System;
namespace DesignPatterns.Adapter
{
	public class StripePaymentAdapter : IPaymentProcessor
	{
		public readonly StripePaymentService _stripePaymentService;

		public StripePaymentAdapter(StripePaymentService stripePaymentService)
		{
			_stripePaymentService = stripePaymentService;
		}

		public void Process(decimal amount)
		{
			Console.WriteLine("adapting stripe processor, I could do something more");

			_stripePaymentService.MakePayment(100m, "Euros");
		}
	}
}

