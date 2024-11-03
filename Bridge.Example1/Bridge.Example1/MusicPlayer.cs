using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    public abstract class MusicPlayer
    {
        protected IFormat _format;

        protected MusicPlayer(IFormat format)
        {
            this._format = format;
        }
        public abstract void Play(string filePath);
    }
}
