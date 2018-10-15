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

        public static bool IsSorted<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, bool> compare)
        {
            TSource prev = default(TSource);
            bool isFirst = true;
            foreach (var e in source)
            {
                if (!isFirst && !compare(prev, e))
                {
                    return false;
                }
                isFirst = false;
                prev = e;
            }
            return true;
        }
    }
}
