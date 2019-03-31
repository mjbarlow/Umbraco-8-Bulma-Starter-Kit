using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using U8StarterKit.Web.Models.Umbraco;

namespace U8StarterKit.Web.Models.ViewModels
{
    public class BlogsViewModel
    {
        public Blog Blog {get; set;}
        public int ItemsToShow {get; set;}
        public List<Blogpost> BlogsPosts {get; set;}
        public bool IsHalfWidth { get; set; }
        public bool HasPaging { get; set; }

    }
}