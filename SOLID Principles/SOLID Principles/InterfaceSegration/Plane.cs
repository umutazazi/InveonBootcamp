using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegration
{
    internal class Plane : IFlyable, IDrivable
    {
        public void Fly()
        {
            Console.WriteLine("Plane is flying.");
        }
        public void Drive()
        {
            Console.WriteLine("Plane is moving on pist");
        }
    }
}
