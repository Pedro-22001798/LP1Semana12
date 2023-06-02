using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int count = 0;
            foreach(object o in items)
            {
                if(o is T)
                    count++;
            }
            return count;
        }
    }
}