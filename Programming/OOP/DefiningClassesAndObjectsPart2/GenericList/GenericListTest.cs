using System;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            // Craeting list of strings
            GenericList<int> list = new GenericList<int>();
            
            // Adding elements in the list

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // Iterate through the elements
            Console.WriteLine("Elements before removing the element at index:{0}", 0);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.WriteLine(list);
            
            // Remove element at position
            list.RemoveAt(0);

            // Iterate through elements
            Console.WriteLine("\nElements after removing the element at index:{0}", 0);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.WriteLine(list);

            // Retrieve the min between two elements
            Console.WriteLine("\nMin element between elements {0} and {1}", 0, 1);
            Console.WriteLine(GenericList<int>.Min<int>(list[0], list[1]));

            // Retrieve the max between two elements
            Console.WriteLine("\nMax element between elements {0} and {1}", 0, 1);
            Console.WriteLine(GenericList<int>.Max<int>(list[0], list[1]));

            // Clearing the list
            list.ClearList();
        }
    }
}
