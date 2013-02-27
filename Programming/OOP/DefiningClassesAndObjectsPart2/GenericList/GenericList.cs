using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T>
        //where T : IComparable<T>
    {
        // Declaring Fields
        private T[] list;
        private int count;
        private static readonly int initialCapacity = 4;

        // Declaring Properties

        // Getting the actual number of elements in the list
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        // Retrieve element at given position
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("Current index:{0} is out of the range", index));
                }

                return list[index];
            } 
            set
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("Current index:{0} is out of the range", index));
                }

                list[index] = value;
            }
        }

        // Constructors

        public GenericList(int capacity)
        {
            list = new T[capacity];
            count = 0;
        }

        public GenericList()
            :this(initialCapacity)
        {
            
        }

        // Methods

        // Adding element in the list
        public void Add(T element)
        {
            InsertAt(this.Count, element);
        }

        // Search for element (retrieving its index or -1 if not exists)
        public int IndexOf(T element)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == (dynamic)element)
                {
                    return i;
                }
            }
            return -1;
        }

        // Insert element at position
        public void InsertAt(int index, T element)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException(string.Format("Current index:{0} is out of the range", index));
            }
            T[] doubledList = list;

            if (count + 1 == list.Length)
            {
                doubledList = new T[list.Length * 2];
            }

            Array.Copy(list, doubledList, index);
            count++;
            Array.Copy(list, index, doubledList, index + 1, count - index - 1);

            doubledList[index] = element;
            list = doubledList;
        }

        // Remove element at position
        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(string.Format("Current index:{0} is out of the range", index));
            }

            T element = list[index];
            Array.Copy(list, index + 1, list, index, count - index + 1);

            if (element.GetType().IsPrimitive)
            {
                list[count - 1] = (dynamic)0;    
            }
            else
            {
                list[count - 1] = (dynamic)null;
            }

            count--;
            return element;
        }

        // Erasing all elements from the list
        public void ClearList()
        {
            list = new T[initialCapacity];
            count = 0;
        }

        // Retrieve the min between two elements
        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
                return first;
            else
                return second;
        }

        // Retrieve the max between two elements
        public static T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
                return second;
            else
                return first;
        }

        // Overrided ToString() method
        public override string ToString()
        {
            // TODO:
            return "";
        }
    }
}
