namespace DesignPatterns.Template.TransactionProcessorExample
{
    public class WithdrawalTransactionProcess : TransactionProcessorTemplate
    {
        protected override void PerformTransaction()
        {
            Console.WriteLine("Perform transaction - Withdrawal");
        }

        protected override void UpdateAccount()
        {
            Console.WriteLine("Update transaction - Withdrawal");
        }

        protected override void ValidateTransaction()
        {
            Console.WriteLine("Validating transaction - Withdrawal");
        }
    }
}

