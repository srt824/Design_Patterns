using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    public abstract class BurgerDecorator : IBurger
    {
        protected IBurger _burger;

        protected BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }
        public virtual double GetCost()
        {
            return _burger.GetCost();
        }

        public virtual string GetDescription()
        {
            return _burger.GetDescription();
        }
    }
}
