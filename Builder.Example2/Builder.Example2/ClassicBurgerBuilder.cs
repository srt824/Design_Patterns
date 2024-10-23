﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();
        public void AddBread()
        {
            _burger.Bread = "Sesame bread";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Cheddar";
        }

        public void AddDressing()
        {
            _burger.Dressing = "Ketchup";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = true;
        }

        public void AddMeat()
        {
            _burger.Meat = "Chicken";
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
