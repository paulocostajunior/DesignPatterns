using DesignPatterns.ChainOfResponsibility.Entities;

namespace DesignPatterns.ChainOfResponsibility
{
    public class CategoryDiscountApproval : DiscountApproval
    {
        public override bool Handle(Product product)
        {
            if (product.Category.Equals(Category.Premium))
            {
                return false;
            }

            return base.Handle(product);
        }
    }
}

