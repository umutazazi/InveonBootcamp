﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution
{
    public class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin is eaiting");
        }
    }
}