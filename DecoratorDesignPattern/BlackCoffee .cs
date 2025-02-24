using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // Concrete Component
    public class BlackCoffee : ICoffee
    {
        public string GetDescription() => "Black Coffee";
        public double GetCost() => 2.0;
    }
}
