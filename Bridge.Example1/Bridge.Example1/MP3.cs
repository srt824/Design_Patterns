using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    public class MP3 : IFormat
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing MP3 file {filePath}");
        }
    }
}
