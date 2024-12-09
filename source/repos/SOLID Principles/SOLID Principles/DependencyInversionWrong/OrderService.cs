using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInversionWrong
{
    /* OrderService, doğrudan SqlDatabase sınıfına bağımlıdır. Eğer SqlDatabase yerine başka bir veri kaynağı (örneğin MongoDatabase) kullanmak istersek, 
     * OrderService'i değiştirmek zorunda kalırız.*/
    internal class OrderService
    {
        private readonly SqlDatabase _database;

        public OrderService()
        {
            _database = new SqlDatabase(); //Doğrudan bağımlılık
        }

        public void ProcessOrder(string order)
        {
            Console.WriteLine($"Order is processing: {order}");
            _database.SaveOrder(order); // Düşük seviyeli modül çağrılıyor
        }
    }

}
