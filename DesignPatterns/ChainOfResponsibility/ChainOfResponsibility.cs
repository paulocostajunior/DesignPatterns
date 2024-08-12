using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Entities;

public class ChainOfResponsibility
{
    public void Execute()
    {
        var product = new Product
        {  
            Id = 1,
            Name = "Mug",
            Category = Category.Standard,
            Price = new Price { Value = 4, Currency = Currency.Standard}
        };

        var _handler = new DiscountApproval();
        var maximumPriceForAllowedDiscount = 10;

        //SETUP
        _handler.SetNext(new CategoryDiscountApproval())
                .SetNext(new PriceDiscountApproval(maximumPriceForAllowedDiscount));

        //EXECUTE
        var isDiscountApproved = _handler.Handle(product);

        Console.WriteLine("the discount result is: " + isDiscountApproved);
    }
}