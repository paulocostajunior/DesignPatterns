using DesignPatterns.ChainOfResponsibility.Entities;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DiscountApproval
    {
        private DiscountApproval? _nextHandler;

        public DiscountApproval SetNext(DiscountApproval handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual bool Handle(Product product)
        {
            return _nextHandler?.Handle(product) ?? true;
        }
    }
}

