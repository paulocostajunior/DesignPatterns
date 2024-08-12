using static ChainOfResponsibility;

namespace DesignPatterns.ChainOfResponsibility.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Category { get; set; }
        public Price Price { get; set; } = new Price();
    }
}

