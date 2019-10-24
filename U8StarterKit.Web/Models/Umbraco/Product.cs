using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using U8StarterKit.Web.Models.Umbraco;


namespace U8StarterKit.Web.Models.Umbraco
{
    public partial class Product : ISectionSettings
    {
        public string ItemsPerRow { get; set; }
    }
}