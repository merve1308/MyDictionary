using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <T1,T2>
    {
        T1[] keys;
        T2[] values;
        T1[] tempKeys;
        T2[] tempValues;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key, T2  value)
        {
            tempKeys = keys;
            tempValues = values;


            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            values[values.Length - 1]= value;

        }
        public int Count
        {
            get { return keys.Length; }
        }
    }
}
