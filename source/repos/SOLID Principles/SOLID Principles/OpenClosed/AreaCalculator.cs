using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OpenClosed
{
    public class AreaCalculator
    {
        public double Calculate(IShape shape)
        {
            return shape.CalculateArea();

        }
    }
}
