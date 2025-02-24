using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // Concrete Decorator
    public class WhippedCream : CoffeeDecorator
    {
        public WhippedCream(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Whipped Cream";
        public override double GetCost() => _coffee.GetCost() + 0.7;
    }
}
