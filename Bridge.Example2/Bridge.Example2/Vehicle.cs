using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public abstract class Vehicle
    {
        protected IEngine _engine;
        protected Vehicle(IEngine engine)
        {
            _engine = engine;
        }
        public abstract void Drive();
    }
}
