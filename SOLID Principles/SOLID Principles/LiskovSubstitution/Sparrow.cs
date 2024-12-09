using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitution
{
    public class Sparrow: Bird,IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("Sparrow is eating");
        }
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }
}
