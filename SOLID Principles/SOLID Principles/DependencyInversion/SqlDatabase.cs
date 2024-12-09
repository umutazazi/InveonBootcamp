using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInversion
{
    internal class SqlDatabase : IDatabase
    {
        public void SaveOrder(string order)
        {
            Console.WriteLine($"SQL Database: order has saved -> {order}");
        }
    }
}
