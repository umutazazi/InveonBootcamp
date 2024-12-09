using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility
{
    public interface IEmailService
    {
        void SendWelcomeEmail(string email)
        {
            Console.WriteLine($"Hoş geldin e-postası {email} adresine gönderildi");
        }
    }
}
