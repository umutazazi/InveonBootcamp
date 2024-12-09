using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegregationWrong
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving on road");
        }

        public void Fly()
        {
            //Araba uçamaz ama implement etmek zorunda
            throw new NotImplementedException();
        }

        public void Sail()
        {
            //Araba yüzemez ama implement etmek zorunda
            throw new NotImplementedException();
        }
    }
}
