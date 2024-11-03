using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example1
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", milk";
        }
        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }
    }
}
