namespace DesignPatterns.Template.TransactionProcessorExample
{
	public abstract class TransactionProcessorTemplate
	{
		public void ProcessTransaction()
		{
			ValidateTransaction();
			PerformTransaction();
			UpdateAccount();
			NotifyUser();
		}

		protected abstract void ValidateTransaction();
		protected abstract void PerformTransaction();
		protected abstract void UpdateAccount();

		protected void NotifyUser()
		{
			//Common behavior
			Console.WriteLine("Transaction completed successfully");
		}
	}
}

