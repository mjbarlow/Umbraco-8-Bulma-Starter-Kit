using System.Collections.Generic;

namespace Umbraco.Web.PublishedModels
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