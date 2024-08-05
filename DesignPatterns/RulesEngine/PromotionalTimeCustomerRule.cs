using System;
using DesignPatterns.Entities;

namespace DesignPatterns.RulesEngine
{
    public class PromotionalTimeCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.NumberOfPurchases % 10 == 0)
            {
                return 0.15m;
            }

            return 0m;
        }
    }
}

