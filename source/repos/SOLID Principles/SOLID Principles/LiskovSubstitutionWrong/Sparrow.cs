using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitutionWrong
{
    public class Sparrow: Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }
}
