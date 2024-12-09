using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LiskovSubstitutionWrong
{
    public class Penguin: Bird
    {
     /*
    Penguin sınıfı, Fly metodunu üst sınıftan miras almış, ancak bu metodu doğru bir şekilde destekleyemiyor.

    Penguin, Bird yerine geçemez çünkü uçma davranışını desteklemesi bekleniyor, ancak bu gerçekleşmiyor.
    */
        public override void Fly()
        {
            //Penguen uçamaz, ama Fly metodu implement etmek zorunda 
            throw new InvalidOperationException();
        }
    }
}
