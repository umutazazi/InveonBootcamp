using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OpenClosedWrong
{
    public class ShapeCalculator
    {
        public double CalculateArea(string shapeType, double dimension1, double dimesion2)
        {
            if(shapeType == "Rectangle")
            {
                return dimension1 * dimesion2;
            }
            else if(shapeType == "Circle")
            {
                return Math.PI * dimension1 * dimension1;
            }
            else
            {
                throw new Exception("Unsupported shape type");
            }
        }
    }
}
