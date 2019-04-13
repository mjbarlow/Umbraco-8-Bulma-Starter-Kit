using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using U8StarterKit.Web.Models.Umbraco;

namespace U8StarterKit.Web.Models.ViewModels
{
    public class BlogItemViewModel
    {
        public Blogpost BlogItem { get; set; }
        public string ItemsPerRow { get; set; }
    }
}