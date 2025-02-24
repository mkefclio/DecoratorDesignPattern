using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // Concrete Decorator
    public class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Milk";
        public override double GetCost() => _coffee.GetCost() + 0.5;
    }
}
