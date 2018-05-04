using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_7
{
    class Generics_7
    {
        class ArrayList
        {
            private object[] _Arr;
            private int _Count;

            public ArrayList()
            {
                _Arr = new object[0];
                Capacity = 0;
                _Count = 0;
            }

            public ArrayList(int StartCapacity)
            {
                _Arr = new object[StartCapacity];
                Capacity = StartCapacity;
                _Count = 0;
            }

            public int Capacity
            {
                get;
                set 
                {
                    if (value > Capacity)
                    {
                        ExpandArray(value - Capacity);
                    }
                    else 
                    {
                        ContractArray(Capacity - value);
                    }
                }
            }

            public int Count
            {
                get { return _Count; }
            }

            public object this[int index]
            {
                get { return _Arr[index]; }
                set { _Arr[index] = value; }
            }

            private void ContractArray(int ContractValue)
            {
                object[] TempArr = _Arr;

                _Arr = new object[Capacity - ContractValue];

                Capacity -= ContractValue;
                _Count = Capacity;

                for (int i = 0; i < Capacity ; ++i)
                {
                    for (int j = 0; j < Capacity; ++j)
                    {
                        _Arr[j] = TempArr[i];
                    }
                }
            }
            private void ExpandArray(int ExpandValue)
            {
                object[] TempArr = _Arr;

                _Arr = new object[Capacity + ExpandValue];

                for (int i = 0; i < Count; ++i)
                {
                    for (int j = 0; j < Count; ++j)
                    {
                        _Arr[j] = TempArr[i];
                    }
                }

                Capacity += ExpandValue;
            }

            public void Add(object obj)
            {
                if (Count == Capacity)
                {
                    ExpandArray(1);
                }
                _Arr[Count] = obj;

                ++_Count;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
