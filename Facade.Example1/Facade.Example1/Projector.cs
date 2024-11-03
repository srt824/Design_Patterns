using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example1
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector turned on");
        }
        public void Off()
        {
            Console.WriteLine("Projector turned off");
        }
    }
}
