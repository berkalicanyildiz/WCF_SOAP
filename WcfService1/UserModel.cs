using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class UserModel
    {
        private List<User> kullaniciliste = new List<User>();

        public UserModel()
        {
            kullaniciliste.Add(new User { Adi = "berk", Sifre = "123" });
        }
        public bool login(string username,string sifre)
        {
            return kullaniciliste.Count(x=>x.Adi.Equals(username) && x.Sifre.Equals(sifre)) > 0;
        }
    }
}