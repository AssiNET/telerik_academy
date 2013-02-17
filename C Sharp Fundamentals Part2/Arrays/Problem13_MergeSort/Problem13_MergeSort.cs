using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_MergeSort
{
    class Problem13_MergeSort
    {
        static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();
            int middle = list.Count / 2;

            for (int index = 0; index < middle; index++)
            {
                leftList.Add(list[index]);
            }

            for (int index = middle; index < list.Count; index++)
            {
                rightList.Add(list[index]);
            }

            leftList = MergeSort(leftList);
            rightList = MergeSort(rightList);

            return Merge(leftList, rightList);
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> sortedList = new List<int>();

            while (left.Count > 0 || right.Count > 0)
	        {
	            if(left.Count > 0 && right.Count > 0)
                {
                    if (left.ElementAt(0) <= right.ElementAt(0))
	                {
		                sortedList.Add(left.ElementAt(0));
                        left.RemoveAt(0);
	                }
                    else 
                    {
                        sortedList.Add(right.ElementAt(0));
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
	            {
		            sortedList.Add(left.ElementAt(0));
                    left.RemoveAt(0);
	            }
                else if (right.Count > 0)
	            {
		            sortedList.Add(right.ElementAt(0));
                    right.RemoveAt(0);
	            }
	        }
            return sortedList;
        }
        
        static void Main(string[] args)
        {
            int[] array = { 2, 9, 6, 8, 7, 9, 8, 6, 1 };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<int> sorted = MergeSort(array.ToList());
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
        }
    }
}