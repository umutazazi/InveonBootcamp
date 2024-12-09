using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility
{
    public class UserRepository : IUserRepository
    {
       public void Add(string username)
        {
            //Veritabanı işlemleri
            Console.WriteLine($"Kullanıcı {username} veritabanına eklendi.");
        }
    }
}
