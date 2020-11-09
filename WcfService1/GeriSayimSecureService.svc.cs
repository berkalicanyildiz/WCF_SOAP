using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GeriSayimSecureService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GeriSayimSecureService.svc or GeriSayimSecureService.svc.cs at the Solution Explorer and start debugging.
    public class GeriSayimSecureService : IGeriSayimSecureService
    {
        public string TestSifre()
        {
           return "Giriş Yapıldı";
        }
    }
}
