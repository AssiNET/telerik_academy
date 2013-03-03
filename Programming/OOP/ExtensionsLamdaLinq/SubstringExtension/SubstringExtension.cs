using System;
using System.Linq;
using System.Text;

namespace SubstringExtension
{
    class SubstringExtension
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1234");
            Console.WriteLine(sb.Substring(0, 2));
        }
    }
}
