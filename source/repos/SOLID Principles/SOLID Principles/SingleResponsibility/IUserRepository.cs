using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility
{
    public interface IUserRepository
    {
        void Add(string username);
    }
}
