using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF_Client
{
    public partial class getjson : System.Web.UI.Page
    {
        ServiceReference1.GeriSayimServiceClient client = new ServiceReference1.GeriSayimServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string veri = client.GetAllJSON();
            List<GeriSayimFromService> list = JsonConvert.DeserializeObject<List<GeriSayimFromService>>(veri);


            gvlist.DataSource = list;
            gvlist.DataBind();
        }
    }
}