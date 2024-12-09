using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OpenClosed
{
    //When we want to add new shape we just add this interface and create a new class.
    public interface IShape
    {
         double CalculateArea();
    }
}
