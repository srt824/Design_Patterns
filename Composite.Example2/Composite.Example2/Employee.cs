using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example2
{
    public class Employee : IEmployee
    {
        private readonly string _name;
        public Employee(string name)
        {
            _name = name;
        }
        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + _name);
        }
    }
}
