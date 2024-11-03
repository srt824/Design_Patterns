﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public interface ICommunication
    {
        string Ask(string question);
        string Reply(string answer);
    }
}
