using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility
{
    public class UserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public UserManager(IUserRepository userRepository, IEmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public void AddUser(string username, string email)
        {
            _userRepository.Add(username);
            _emailService.SendWelcomeEmail(email);
        }
    }
}
