using System;
namespace DesignPatterns.Adapter
{
	public class PaymentProcessClient
	{
		private readonly IPaymentProcessor _paymentProcessor;

		public PaymentProcessClient(IPaymentProcessor paymentProcessor)
		{
			_paymentProcessor = paymentProcessor;
		}

		public void MakePayment(decimal amount)
		{
			_paymentProcessor.Process(amount);
		}
	}
}

