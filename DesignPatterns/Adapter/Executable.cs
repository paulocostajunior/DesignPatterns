using System;
namespace DesignPatterns.Adapter
{
	public class Executable
	{
		public void Run()
		{
			var paypalProcessor = new PaypalPaymentProcessor();
			var paypalClient = new PaymentProcessClient(paypalProcessor);
			paypalClient.MakePayment(100m);

			var stripePaymentService = new StripePaymentService();
			var stripePaymentAdapter = new StripePaymentAdapter(stripePaymentService);
			var stripeClient = new PaymentProcessClient(stripePaymentAdapter);
			stripeClient.MakePayment(250m);
		}
	}
}

