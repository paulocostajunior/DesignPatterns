using System;
using DesignPatterns.Entities;

namespace DesignPatterns.Template.PizzaExample
{
    public class PizzaBakingService : PanFoodServiceBase<Pizza>
    {
        protected override void PrepareCrust()
        {
            Console.WriteLine("Rolling out and hand tossing the dough");
            _item.CrustType = "Thin";
        }

        protected override void AddTopping()
        {
            Console.WriteLine("Adding pizza toppings");
            _item.Toppings.Add("Onion");
            _item.Toppings.Add("Egg");
        }

        protected override void Bake()
        {
            Console.WriteLine("Baking for 5 min");
            _item.WasBaked = true;
        }

        protected override void Slice()
        {
            Console.WriteLine("Cutting into 8 slices");
            _item.NumSlices = 8;
        }
    }
}

