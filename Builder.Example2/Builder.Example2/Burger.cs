using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Dressing { get; set; }
        public bool Lettuce { get; set; }
        public bool Tomato { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($@"Bread: {Bread}, Meat: {Meat}, Cheese {Cheese}
                , Dressing: {Dressing}, Lettuce: {Lettuce}, Tomato: {Tomato}");
        }
    }
}
