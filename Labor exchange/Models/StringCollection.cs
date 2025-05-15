using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.Models
{
    public class TCollection <T>
    {
        private const int INIT_CAPACITY = 10;
        private T[] arr;
        public int Count { private set; get; }

        public TCollection()
        {
            arr = new T[INIT_CAPACITY];
            Count = 0;
        }

        public void Add(T s)
        {
            if (Count == arr.Length)
                Extend();
            arr[Count++] = s;
        }

        private void Extend()
        {
            throw new NotImplementedException();
        }

        public T this[int i]
        {
            set { arr[i] = value; }
            get { return arr[i]; }
        }
    }
}
