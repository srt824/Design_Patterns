using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the electric engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the electric engine");
        }
    }
}
