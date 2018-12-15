using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppBD
{
    public class User
    {
        private string login;
        private string password;
        private int privilageLevel; // Higher level = more options in app
        private Boolean isLogged = false;

        public bool IsLogged { get => isLogged; set => isLogged = value; }
        public int PrivilageLevel { get => privilageLevel; set => privilageLevel = value; }
        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }
    }
}
