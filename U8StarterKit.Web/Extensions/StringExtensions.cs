using System;
using System.Text.RegularExpressions;
using Umbraco.Core;
using System.Text;
using System.Globalization;

namespace U8StarterKit.Web.Extensions
{
    public static class StringExtensions
    {
        public static string JsonToLogString(this string value)
        {
            return value.Replace("\":\"", ": ").Replace("\",\"", ", ").Replace('"', ' ').Replace("{", string.Empty)
                .Replace("}", string.Empty)
                .Replace("[", string.Empty).Replace("]", string.Empty).Replace("  ", string.Empty).Trim();
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static bool IsPictureUrl(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            return Contains(value, ".jpg", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool HasValue(this string value)
        {
            return !value.IsNullOrWhiteSpace();
        }

        private static readonly Regex sWhitespace = new Regex(@"\s+");

        public static string ReplaceWhitespace(this string value)
        {
            return sWhitespace.Replace(value, string.Empty); 
        }

        public static string StripQueryString(this string value)
        {
            var index = value.IndexOf('?');

            if (index > 0)
            {
                return value.Substring(0, index);
            }

            return value;
        }

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }


        public static string UrlFriendly(this string text, int maxLength = 0)
        {
            // Return empty value if text is null
            if (text == null) return "";
            var normalizedString = text
                // Make lowercase
                .ToLowerInvariant()
                // Normalize the text
                .Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            var stringLength = normalizedString.Length;
            var prevdash = false;
            var trueLength = 0;
            char c;
            for (int i = 0; i < stringLength; i++)
            {
                c = normalizedString[i];
                switch (CharUnicodeInfo.GetUnicodeCategory(c))
                {
                    // Check if the character is a letter or a digit if the character is a
                    // international character remap it to an ascii valid character
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        if (c < 128)
                            stringBuilder.Append(c);
                        else
                            stringBuilder.Append(CharExtensions.RemapInternationalCharToAscii(c));
                        prevdash = false;
                        trueLength = stringBuilder.Length;
                        break;
                    // Check if the character is to be replaced by a hyphen but only if the last character wasn't
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.ConnectorPunctuation:
                    case UnicodeCategory.DashPunctuation:
                    case UnicodeCategory.OtherPunctuation:
                    case UnicodeCategory.MathSymbol:
                        if (!prevdash)
                        {
                            stringBuilder.Append('-');
                            prevdash = true;
                            trueLength = stringBuilder.Length;
                        }
                        break;
                }
                // If we are at max length, stop parsing
                if (maxLength > 0 && trueLength >= maxLength)
                    break;
            }
            // Trim excess hyphens
            var result = stringBuilder.ToString().Trim('-');
            // Remove any excess character to meet maxlength criteria
            return maxLength <= 0 || result.Length <= maxLength ? result : result.Substring(0, maxLength);
        }

    
    }
}
