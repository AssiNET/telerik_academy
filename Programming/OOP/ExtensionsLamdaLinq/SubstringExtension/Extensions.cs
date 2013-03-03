using System;
using System.Linq;
using System.Text;

namespace SubstringExtension
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder sb, int index, int length)
        {
            string str = sb.ToString().Substring(index, length);
            return str;
        }
    }
}
