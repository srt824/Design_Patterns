using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    public class BasicBurger : IBurger
    {
        public double GetCost()
        {
            return 3.0;
        }

        public string GetDescription()
        {
            return "Basic burger";
        }
    }
}
