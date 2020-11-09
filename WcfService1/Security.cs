using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfService1
{
    public class Security : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            UserModel userModel = new UserModel();
            if (userModel.login(userName, password))
                return;


            throw new FaultException("Hatalı Kullanıcı Adı veya Şifre");

        }
    }
}