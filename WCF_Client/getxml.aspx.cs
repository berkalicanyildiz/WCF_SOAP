﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF_Client
{
    public partial class getxml : System.Web.UI.Page
    {
        ServiceReference1.GeriSayimServiceClient client = new ServiceReference1.GeriSayimServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var list= client.GetAllXML();

            gvlist.DataSource = list;
            gvlist.DataBind();
        }
    }
}