using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    public class BaconDecorator : BurgerDecorator
    {
        public BaconDecorator(IBurger burger) : base(burger)
        {
        }
        public override string GetDescription()
        {
            return _burger.GetDescription() + ", bacon";
        }
        public override double GetCost()
        {
            return _burger.GetCost() + 1.0;
        }
    }
}
