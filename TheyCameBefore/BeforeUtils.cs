using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> list, T item) where T : struct, IComparable<T>
        {
            foreach (var element in list)
            {
                if(element.CompareTo(item) < 0)
                    yield return element;
            }
        }
    }
}