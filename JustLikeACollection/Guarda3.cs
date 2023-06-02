using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T item1;
        private T item2;
        private T item3;

        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);            
        }

        public T GetItem(int i)
        {
            if(i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            return i switch
            {
                0 => item1,
                1 => item2,
                2 => item3,
                _ => default(T)
            };
        }

        public void SetItem(int i, T item)
        {
            if(i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    item1 = item;
                    break;
                case 1:
                    item2 = item;
                    break;
                case 2:
                    item3 = item;
                    break;
            }
        }

        public void Add(T item)
        {
            if (item1 == null || item1.Equals(default(T)))
            {
                item1 = item;
            }
            else if (item2 == null || item2.Equals(default(T)))
            {
                item2 = item;
            }
            else if (item3 == null || item3.Equals(default(T)))
            {
                item3 = item;
            }
            else
            {
                throw new InvalidOperationException("Not enought space");
            }            
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return item1;
            yield return item2;
            yield return item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}