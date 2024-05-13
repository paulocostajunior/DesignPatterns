namespace DesignPatterns.Template.TransactionProcessorExample
{
	public class DepositTransactionProcessor : TransactionProcessorTemplate
	{
        protected override void ValidateTransaction()
        {
            Console.WriteLine("Validating transaction - Deposit");
        }

        protected override void PerformTransaction()
        {
            Console.WriteLine("Performing transaction - Perform");
        }

        protected override void UpdateAccount()
        {
            Console.WriteLine("Updating account - Update");
        }
    }
}

