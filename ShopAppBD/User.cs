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
        private int privilageLevel;
        private Boolean isLogged = false;

        public void SetLogin(string login)
        {
            this.login = login;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetLogin()
        {
            return this.login;
        }

        public void SetPrivilageLevel(int privilageLevel)
        {
            this.privilageLevel = privilageLevel;
        }

        public int GetPrivilageLevel()
        {
            return this.privilageLevel;
        }

        public void SetIsLogged(Boolean isLogged)
        {
            this.isLogged = isLogged;
        }

        public Boolean GetIsLogged()
        {
            return this.isLogged;
        }
    }
}
