namespace DesignPatterns.Strategy
{
    public class DiscountCalculator
	{
		public static void Execute()
		{
            var isNewClient = true;

            var discount = FindClientType(isNewClient);

            discount.CalculateDiscount();
		}

        public static IDiscount FindClientType(bool isNewClient)
        {
            if (isNewClient)
            {
                return new NewClient();
            }

            return new OldClient();
        }
	}
}