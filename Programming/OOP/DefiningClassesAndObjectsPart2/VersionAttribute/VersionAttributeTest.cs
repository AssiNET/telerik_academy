using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [VersionAttribute(6,-1)]
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            Type type = typeof(VersionAttributeTest);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("The version of the class is {0} ", versionAttribute);
            }
        }
    }
}
