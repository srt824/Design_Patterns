using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example1
{
    public interface IFileSystemItem
    {
        void Display(string indent = "");
    }
}
