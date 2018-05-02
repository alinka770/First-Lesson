using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2
{
    class Generics_2
    {
        class MyList<T>: IEnumerable<T> 
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
                this.elems[this.size-1] = additionElem;
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
                    if(index >= this.size)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else if(index<0)
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
                    else { this.elems[index]=value; }
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

            public bool Remove (T elem)
            {
                int index = this.IndexOf(elem);
                --size;
                if (index<this.size && index!=-1)
                {
                    Array.Copy(this.elems, index + 1, this.elems, index, size - index);
                    Array.Resize(ref this.elems, size);
                    return true;
                }
                else if(index==this.size)
                {
                    Array.Resize(ref this.elems, size);
                    return true;
                }
                return false;
            }
            
        }


        static void Main(string[] args)
        {

            MyList<int> list1 = new MyList<int>() {1,2,3,4,5,6,7};
            Console.WriteLine("Elements of the original list:");
            foreach(int el in list1)
            {
                Console.Write(el+" ");
            }
            list1.Add(8);
            Console.WriteLine("\nElements after adding '8':");
            foreach (int el in list1)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\nLength of the list: "+list1.Count);
            Console.WriteLine("Does the list contain '8'? " + list1.Contains(8));
            list1.Remove(8);
            Console.WriteLine("Elements after removing '8':");
            foreach (int el in list1)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine("\nIndex of '3': "+list1.IndexOf(3));
            Console.WriteLine("The 3-rd element: " + list1[2]);
            Console.ReadKey();
        }
    }
}
