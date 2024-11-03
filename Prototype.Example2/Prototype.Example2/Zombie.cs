using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public class Zombie : Monster
    {
        public int Health { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Zombie {Id} ({Name}) attacks with {Health} health points.");
        }
    }
}
