using System.Text.RegularExpressions;
using System.Web;

namespace U8StarterKit.Web.Extensions
{
    public static class HtmlStringExtensions
    {   

        public static bool HasValue(this IHtmlString value)
        {
            return !string.IsNullOrWhiteSpace(value.ToString());
        }

        public static IHtmlString StripHtml(this IHtmlString value)
        {
            const string pattern = @"<(.|\n)*?>";
            var result = new HtmlString(Regex.Replace(value.ToString(), pattern, string.Empty));
            return result;
        }

        public static IHtmlString GetFirstParagraph(this IHtmlString value)
        {
            var match = Regex.Match(value.ToString(), @"<p>\s*(.+?)\s*</p>");
            var result = new HtmlString(match.Success ? match.Groups[1].Value : string.Empty);
            return result;
        }
    }
}