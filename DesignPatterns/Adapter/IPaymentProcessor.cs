using System;
namespace DesignPatterns.Adapter
{
	public interface IPaymentProcessor
	{
		public void Process(decimal amount);
	}
}

