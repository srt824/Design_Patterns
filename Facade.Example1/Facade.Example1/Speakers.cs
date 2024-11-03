using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example1
{
    public class Speakers
    {
        public void On()
        {
            Console.WriteLine("Speakers turned on");
        }
        public void Off()
        {
            Console.WriteLine("Speakers turned off");
        }
    }
}
