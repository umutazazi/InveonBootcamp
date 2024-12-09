using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegration
{
    internal class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving on road");
        }
    }
}
