﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OpenClosed
{
    public class Rectangle : IShape
    {
        public double Width;
        public double Height;
        
        public Rectangle(double width, double height) { 
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return Height * Width;
        }
    }
}
