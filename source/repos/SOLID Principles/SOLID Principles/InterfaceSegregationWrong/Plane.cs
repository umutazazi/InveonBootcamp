using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegregationWrong
{
    public class Plane : IVehicle
    {
        public void Drive()
        {
            //Uçak yolda gidemez ama implemet etmek zorunda
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }

        public void Sail()
        {
            //Uçak yüzemez ama implement etmek zorunda
            throw new NotImplementedException();
        }
    }
}
