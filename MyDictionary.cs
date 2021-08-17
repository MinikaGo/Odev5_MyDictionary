using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class MyDictionary<T1, T2>
    {
        T1[] keys;
        T2[] items;
        public MyDictionary()
        {
            keys = new T1[0];
            items = new T2[0];

        }
        public void Add(T1 key, T2 item)
        {
            T1[] tempKeys = keys;
            T2[] tempArray = items;
            keys = new T1[keys.Length + 1];
            items = new T2[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempKeys[i];
                items[i] = tempArray[i];
            }

            keys[items.Length - 1] = key;
            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }

        public void Listed()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("[{0} , {1}]", keys[i], items[i]);
            }
        }

    }
}
