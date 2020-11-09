using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF_Client
{
    public partial class password : System.Web.UI.Page
    {
        ServiceReference2.GeriSayimSecureServiceClient client = new ServiceReference2.GeriSayimSecureServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            client.ClientCredentials.UserName.UserName = "berk";
            client.ClientCredentials.UserName.Password = "1234";
            try
            {
                var result = client.TestSifre();
                if (result==null)
                {
                    lbltest.Text = "Hata";
                }
                else
                {
                    lbltest.Text = result;
                }

            }
            catch
            {
                lbltest.Text = "Hata";
                
                
            }
        }
    }
}