using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Client
{
    public class GeriSayimFromService
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Color { get; set; }
    }
}