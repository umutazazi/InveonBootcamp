using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegration
{
    internal class Boat : ISailable
    {
        public void Sail()
        {
            Console.WriteLine("Boat is sailing");
        }
    }
}
