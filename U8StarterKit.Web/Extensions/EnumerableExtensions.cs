using System;
using System.Collections.Generic;
using System.Linq;

namespace U8StarterKit.Web.Extensions
{
    public static class EnumerableExtensions
    {

        /// <summary>
        /// Split a collection into equal chunks.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static List<List<T>> Split<T>(this IEnumerable<T> collection, int size)
        {
            var chunks = new List<List<T>>();
            var count = 0;
            var temp = new List<T>();

            foreach (var element in collection)
            {
                if (count++ == size)
                {
                    chunks.Add(temp);
                    temp = new List<T>();
                    count = 1;
                }
                temp.Add(element);
            }
            chunks.Add(temp);

            return chunks;
        }

        /// <summary>
        /// Get distinct in a list by a key value.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (!seenKeys.Contains(keySelector(element)))
                {
                    seenKeys.Add(keySelector(element));
                    yield return element;
                }
            }
        }

        //
        public static bool HasValue<T>(this IEnumerable<T> content)
        {
            return content != null && content.Any();
        }
    }
}
