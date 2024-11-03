using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class Bus : Vehicle
    {
        public Bus(IEngine engine) : base(engine)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Driving the bus");
            _engine.Start();
        }
    }
}
