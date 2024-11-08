using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membeship
{
    public class AuthServices : IAuthServices
    {
        public bool ForgetPassword(string username)
        {
            throw new NotImplementedException();
        }

        public bool login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            throw new NotImplementedException();
        }

        public bool ResetPassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
