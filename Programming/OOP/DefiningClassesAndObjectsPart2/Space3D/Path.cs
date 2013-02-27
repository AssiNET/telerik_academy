using System;
using System.Collections.Generic;
using System.Linq;

namespace Space3D
{
    public class Path : List<Point3D>
    {
        // Declaring Fields
        private int pointIndex;

        // Declaring Properties
        public int PointIndex
        {
            get
            {
                return this.pointIndex;
            }
        }

        // Constructors
        public Path() : base()
        {
            pointIndex = 0;
        }

        // Methods
        public int AddPoint(int x, int y, int z)
        {
            this.Add(new Point3D(x, y, z));

            return pointIndex++;
        }

        //public void ClearPoints()
        //{
        //    this.Clear();
        //}

        //public void RemovePointAt(int index)
        //{
        //    this.RemoveAt(index);
        //}

        //public void RemovePoint(Point3D point)
        //{
        //    this.Remove(point);
        //}
    }
}
