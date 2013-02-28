using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | 
                    AttributeTargets.Class | 
                    AttributeTargets.Interface | 
                    AttributeTargets.Method | 
                    AttributeTargets.Enum)]
    class VersionAttribute : System.Attribute
    {
        private int majorVersion;
        private int minorVersion;

        public int MajorVersion
        {
            get
            {
                return this.majorVersion;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Major version has to be positive number.");
                }
                this.majorVersion = value;
            }
        }

        public int MinorVersion
        {
            get
            {
                return this.minorVersion;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Minor version has to be positive number." + value);
                }
                this.minorVersion = value;
            }
        }
                
        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}", MajorVersion, MinorVersion);
        }
    }
}
