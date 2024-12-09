using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInversion
{
    internal class OrderService
    {
        private readonly IDatabase _database;

        public OrderService(IDatabase database)
        {
            _database = database; // Soyutlamaya bağımlılık
        }

        public void ProcessOrder(string order)
        {
            Console.WriteLine($"Order is proccessing: {order}");
            _database.SaveOrder(order); // Soyutlama üzerinden çağrı
        }
    }
}
