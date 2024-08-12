using System;
using DesignPatterns.ChainOfResponsibility.Entities;

namespace DesignPatterns.ChainOfResponsibility
{
    public class PriceDiscountApproval : DiscountApproval
    {
        private decimal _maximumPriceForAllowedDiscount;

        public PriceDiscountApproval(decimal maximumPriceForAllowedDiscount)
        {
            _maximumPriceForAllowedDiscount = maximumPriceForAllowedDiscount;
        }

        public override bool Handle(Product product)
        {
            if (product.Price.Value > _maximumPriceForAllowedDiscount)
            {
                return false;
            }

            return base.Handle(product);
        }
    }
}

