using DesignPatterns.Entities;

namespace DesignPatterns.RulesEngine
{
	public interface IDiscountRule
	{
		public decimal CalculateDiscount(Customer customer, decimal currentDiscount);
	}
}