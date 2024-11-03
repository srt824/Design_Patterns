using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    public class WAV : IFormat
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing WAV file {filePath}");
        }
    }
}
