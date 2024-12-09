using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInversionWrong
{
    internal class SqlDatabase
    {
        public void SaveOrder(string order)
        {
            Console.WriteLine($"SQL Database: Order has saved  -> {order}");
        }
    }
}
