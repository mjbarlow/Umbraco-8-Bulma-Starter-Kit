﻿
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;

namespace U8StarterKit.Web.Extensions
{
    /// <summary>
    /// A few useful extension methods for Umbraco IpublishedContent
    /// </summary>
    public static partial class UmbracoExtensions
    {

        /// <summary>
        /// Check if the IPublished Content has a value
        /// </summary>
        /// <param name="content">The current content</param>
        /// <returns>If a value is set</returns>
        public static bool HasValue(this IPublishedContent content)
        {
            return content != null;
        }
    }
}