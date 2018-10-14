using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLibrary
{
    public static class IEnumerableExtentions
    {
        public static IEnumerable<TSource> PushFront<TSource>(this IEnumerable<TSource> source, TSource element)
        {
            yield return element;
            foreach (var e in source)
            {
                yield return e;
            }
        }

        public static IEnumerable<TSource> PushBack<TSource>(this IEnumerable<TSource> source, TSource element)
        {
            foreach (var e in source)
            {
                yield return e;
            }
            yield return element;
        }
    }
}
