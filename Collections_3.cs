using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_3
{
    class Collections_3
    {
        class Dictionary<TKey, TValue>: IEnumerator, IEnumerable
        {
            class Value
            {
                public TKey Key;
                private TValue InValue;

                public Value(TKey NKey, TValue NValue)
                {
                    Key = NKey;
                    InValue = NValue;
                }

                public TValue GetValue()
                {
                    return InValue;
                }
            }

            private List<Value> _collection;

            IEnumerator MyEnumerator;

            private int _index;

            public Dictionary()
            {
                _collection = new List<Value>();
                _index = 0;
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

            public IEnumerator GetEnumerator()
            {
                return MyEnumerator;
            }

            public Object Current
            {
                get { return _collection[_index]; }
            }

            public bool MoveNext()
            {
                if (_collection.Count >= _index + 1)
                {
                    ++_index;
                    return true;
                }
                else return false;
            }
            public void Reset()
            {
                _index = 0;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}