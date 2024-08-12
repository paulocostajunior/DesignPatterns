using static ChainOfResponsibility;

namespace DesignPatterns.ChainOfResponsibility.Entities
{
    public class Price
    {
        public decimal Value { get; set; }
        public Currency Currency { get; set; }
    }
}

