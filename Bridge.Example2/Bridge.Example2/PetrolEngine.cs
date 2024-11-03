using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the petrol engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the petrol engine");
        }
    }
}
