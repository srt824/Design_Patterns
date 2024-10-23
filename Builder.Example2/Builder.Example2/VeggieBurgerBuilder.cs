using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    public class VeggieBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();
        public void AddBread()
        {
            _burger.Bread = "Whole Wheat";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Vegan cheese";
        }

        public void AddDressing()
        {
            _burger.Dressing = "Vegan mayo";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = true;
        }

        public void AddMeat()
        {
            _burger.Meat = "Lentil patty";
        }

        public void AddTomato()
        {
            _burger.Tomato = true;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
