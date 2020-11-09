using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGeriSayimService" in both code and config file together.
    [ServiceContract]

    public interface IGeriSayimService
    {
        [OperationContract]
        //[System.ServiceModel.Web.WebInvoke(Method = "POST", ResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json)]
        string DoWork();

        [OperationContract]
        [WebInvoke(Method ="GET",RequestFormat =WebMessageFormat.Xml)]
        List<Geri_Sayimlar> GetAllXML();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json)]

        string GetAllJSON();

    }
}
