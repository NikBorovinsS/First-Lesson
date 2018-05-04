using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_4
{
    class MyList<T> : IEnumerable<T> 
    {
        private T[] elems;
        private int size;
        public int Count { get { return size; } }

        public MyList()
        {
            this.elems = new T[size];
        }

        public MyList(int capacity)
        {
            size = capacity;
            this.elems = new T[size];
        }

        public MyList(IEnumerable<T> collection)
        {
            this.elems = new T[size];
            this.AddRange(collection);
        }

        public void Add(T additionElem)
        {
            Array.Resize<T>(ref this.elems, ++this.size);
            this.elems[this.size - 1] = additionElem;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T e in collection)
            {
                this.Add(e);
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.size)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (index < 0)
                {
                    throw new FormatException();
                }
                else { return this.elems[index]; }
            }
            set
            {
                if (index >= this.size)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (index < 0)
                {
                    throw new FormatException();
                }
                else { this.elems[index] = value; }
            }
        }

        public bool Contains(T neededElem)
        {
            foreach (T elem in elems)
            {
                if (elem.Equals(neededElem))
                { return true; }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)elems).GetEnumerator();
        }

        public int IndexOf(T elem)
        {
            return Array.IndexOf(this.elems, elem);
        }

        public bool Remove(T elem)
        {
            int index = this.IndexOf(elem);
            --size;
            if (index < this.size && index != -1)
            {
                Array.Copy(this.elems, index + 1, this.elems, index, size - index);
                Array.Resize(ref this.elems, size);
                return true;
            }
            else if (index == this.size)
            {
                Array.Resize(ref this.elems, size);
                return true;
            }
            return false;
        }
    }
       
        static class Generics_4
        {
            public static T[] GetArray<T>(this MyList<T> list)
            {
                T[] result = new T[list.Count];
                for (int i=0; i<list.Count; i++)
                {
                    result[i] = list[i];
                }
                return result;
            }

            static void Main(string[] args)
            {
                MyList<int> list = new MyList<int>() {1,2,3,4,5,6,7,8 };
                Console.WriteLine("Elements of the resulting array: ");
                foreach (int elem in list.GetArray())
                { Console.Write(elem + " "); }
                Console.ReadKey();
            }
        }
    }
