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

            // Retrieve the min element in the list
            Console.Write("\nMin element in the list: ");
            Console.WriteLine(GenericList<int>.Min<int>(list));

            // Retrieve the max element in the list
            Console.Write("\nMax element in the list: ");
            Console.WriteLine(GenericList<int>.Max<int>(list));

            // Clearing the list
            list.ClearList();
        }
    }
}
