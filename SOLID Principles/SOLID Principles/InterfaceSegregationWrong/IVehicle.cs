using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.InterfaceSegregationWrong
{
    /* 
     IVehicle arayüzü çok geniş olduğu için, 
    arayüzü implemente eden sınıflar yalnızca ihtiyaç duydukları metotlara odaklanamıyor.
     */
    internal interface IVehicle
    {
        void Drive();
        void Fly();
        void Sail();
    }
}
