using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U8StarterKit.Web.Helpers
{
    public static class RazorHelper
    {
        public static string ColumnClass(string itemsPerRow)
        {
            var result = "is-12";
            switch (itemsPerRow)
            {
                case "2":
                    result = "is-6";
                    break;
                case "3":
                    result = "is-4";
                    break;
                case "4":
                    result = "is-3";
                    break;
            }
            return result;
        }

        public static string BackgroundColorClass(string background)
        {
            var result = "";

            switch (background)
            {
                case "Primary":
                    result = "has-background-primary";
                    break;
                case "Secondary":
                    result = "has-background-info";
                    break;
                case "Light":
                    result = "has-background-light";
                    break;
                case "Dark":
                    result = "has-background-dark";
                    break;
                case "White":
                    result = "has-background-white";
                    break;
                case "Gray":
                    result = "has-background-grey-lighter";
                    break;
            }
            return result;
        }
    }
}
