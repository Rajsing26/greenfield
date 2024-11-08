using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membeship
{
    public interface IAuthServices
    {
        bool login(string username, string password);
        bool Register(User user);
        bool ForgetPassword(string username);
        bool ResetPassword(string username, string oldPassword, string newPassword);
    }
}
