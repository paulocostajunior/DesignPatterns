
using DesignPatterns.Entities;

namespace DesignPatterns.RulesEngine
{
	public class FirstTimeCustomerRule : IDiscountRule
	{
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.DateOfFirstPurchase.HasValue)
            {
                return .20m;
            }
            return 0;
        }
    }
}

