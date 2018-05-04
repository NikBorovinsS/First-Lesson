using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_6
{
    class Dictionary<TKey, TValue>:IDictionary<TKey, TValue>
    {
        class Value
        {
            public TKey Key;
            private TValue Value;

            public Value(TKey NKey, TValue NValue)
            {
                Key = NKey;
                Value = NValue;
            }

            public TValue GetValue()
            {
                return Value;
            }
        }

        private List<Value> _collection;

        public Dictionary()
        {
            _collection = new List<Value>();
        }

        public void Add(TKey key, TValue value)
        {
            _collection.Add(new Value(key, value));
        }

        public int Count
        {
            get { return _collection.Count; }
        }

        public TValue this[int index]
        {
            get
            {
                return _collection[index].GetValue();
            }
        }
    }

    class Generics_6
    {
        static void Main(string[] args)
        {
        }
    }
}
