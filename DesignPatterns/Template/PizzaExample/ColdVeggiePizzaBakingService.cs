using DesignPatterns.Entities;

namespace DesignPatterns.Template.PizzaExample
{
	public class ColdVeggiePizzaBakingService : PanFoodServiceBase<ColdVeggiePizza>
	{
        protected override void AddTopping()
        {
            Console.WriteLine("Adding veggie toppings");
        }

        protected override void PrepareCrust()
        {
            Console.WriteLine("Rolling out dough and press into pan");
        }

        protected override void Slice()
        {
            Console.WriteLine("Slice into squares");
        }
    }
}

