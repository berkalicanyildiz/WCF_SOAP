using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WcfService1
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GeriSayimService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GeriSayimService.svc or GeriSayimService.svc.cs at the Solution Explorer and start debugging.
    public class GeriSayimService : IGeriSayimService
    {
        geri_sayim_apiEntities db = new geri_sayim_apiEntities();
       
        public List<Geri_Sayimlar> GetAllXML()
        {
            return db.Geri_Sayimlar.ToList();
        }

        string IGeriSayimService.DoWork()
        {
            return "Hello World";
        }

        string IGeriSayimService.GetAllJSON()
        {
            return JsonConvert.SerializeObject(db.Geri_Sayimlar.ToList());
        }
    }
}
