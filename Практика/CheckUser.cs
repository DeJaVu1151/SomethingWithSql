using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика
{
    public class CheckUser
    {
        public string Login { get; set; }

        public bool Is_admin { get; }

        public string Status => Is_admin ? "Админ" : "Пользователь";

        public CheckUser(string login, bool is_admin) 
        {
            Login = login.Trim();
            Is_admin = is_admin;
        }
    }
}
