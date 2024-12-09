using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibilityWrong
{
    /* 
     Problemler:

    1. UserManager sınıfı hem veri işleme (kullanıcıyı kaydetme) hem de e-posta gönderme sorumluluğunu üstleniyor.
    2. Eğer e-posta göndermede bir değişiklik yapılması gerekirse, kullanıcı işlemleriyle ilgili kodlar da etkilenebilir.
    3. Test edilmesi zorlaşır çünkü her iki sorumluluk birbiriyle bağlantılıdır.
     */
    public class UserManager
    {
        public void AddUser(string username, string email)
        {
            // Kullanıcıyı veritabanına ekle (External bir metod)
            Console.WriteLine($"Kullanıcı {username} veritabanına eklendi.");

            // Kullanıcıya hoş geldin e-postası gönder
            Console.WriteLine($"Hoş geldin e-postası {email} adresine gönderildi.");
        }
    }
}
