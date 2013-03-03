using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtensionSet
{
    public static class Extensions
    {
        public static decimal Sum<T>(this IEnumerable<T> vars)
        {
            if (vars == null)
            {
                throw new ArgumentNullException();
            }

            decimal sum = 0M;

            foreach (var item in vars)
            {
                sum += Convert.ToDecimal(item);
            }

            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> vars)
        {
            if (vars == null)
            {
                throw new ArgumentNullException();
            }

            decimal product = 1M;

            foreach (var item in vars)
            {
                product *= Convert.ToDecimal(item);
            }

            return product;
        }

        public static decimal Average<T>(this IEnumerable<T> vars)
        {
            if (vars == null)
            {
                throw new ArgumentNullException();
            }

            decimal average = 0M;
            int count = 0;
            
            foreach (var item in vars)
            {
                average += Convert.ToDecimal(item);
                count++;
            }

            return average /= count;
        }

        public static T Min<T>(this IEnumerable<T> vars)
            where T : IComparable<T>
        {
            if (vars == null)
            {
                throw new ArgumentNullException();
            }

            T min = vars.First<T>();
            
            foreach (var item in vars)
	        {
		        if (item.CompareTo(min) < 0)
	            {
                    min = item;
	            }
	        }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> vars)
            where T : IComparable<T>
        {
            if (vars == null)
            {
                throw new ArgumentNullException();
            }

            T max = vars.First<T>();
            
            foreach (var item in vars)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
