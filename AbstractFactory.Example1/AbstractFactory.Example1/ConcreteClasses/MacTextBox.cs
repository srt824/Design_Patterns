﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1.ConcreteClasses
{
    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac TextBox");
        }
    }
}
