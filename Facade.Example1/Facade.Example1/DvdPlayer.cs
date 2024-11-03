using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example1
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player turned on");
        }
        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Playing movie '{movie}'");
        }
        public void Off()
        {
            Console.WriteLine("DVD Player turned off");
        }
    }
}
