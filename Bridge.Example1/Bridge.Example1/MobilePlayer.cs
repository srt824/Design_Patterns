using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    public class MobilePlayer : MusicPlayer
    {
        public MobilePlayer(IFormat format) : base(format)
        {
        }

        public override void Play(string filePath)
        {
            Console.WriteLine("Using Mobile Player");
            _format.Play(filePath);
        }
    }
}
