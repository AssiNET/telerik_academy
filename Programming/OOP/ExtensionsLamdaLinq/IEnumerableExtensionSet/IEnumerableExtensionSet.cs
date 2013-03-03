using System;
using System.Linq;

namespace IEnumerableExtensionSet
{
    class IEnumerableExtensionSet
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sum: {0}", arr.Sum<int>());
            Console.WriteLine("Product: {0}", arr.Product<int>());
            Console.WriteLine("Average: {0}", arr.Average<int>());
            Console.WriteLine("Min: {0}", arr.Min<int>());
            Console.WriteLine("Max: {0}", arr.Max<int>());
        }
    }
}
