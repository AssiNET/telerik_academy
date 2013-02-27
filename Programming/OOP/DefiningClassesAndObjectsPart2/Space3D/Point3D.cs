using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public struct Point3D
    {
        // Declaring Fields
        private int x;
        private int y;
        private int z;
        private int index;
        private static int number;
        private static readonly Point3D origin;
        
        // Declaring Properties

        public static Point3D Origin
        {
            get
            {
                return origin;
            }
        }

        private static int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        // Constructors

        static Point3D()
        {
            Number = 0;
            origin = new Point3D(0, 0, 0);
            origin.Index = 0;
        }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Index = Number++;
        }

        // Methods

        public override string ToString()
        {
            return string.Format("p{0}({1},{2},{3})", this.Index, this.X, this.Y, this.Z);
        }
    }
}
