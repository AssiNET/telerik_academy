using System;
using System.Linq;

namespace Space3D
{
    class Space3DTest
    {
        static void Main(string[] args)
        {
            // Origin Point
            Console.WriteLine(Point3D.Origin);
            Console.WriteLine();

            // Distance Between Two Points
            Point3D p1 = new Point3D(0, 2, 3);
            Point3D p2 = new Point3D(1, 4, 3);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("Distance: {0}", Point.Distance(p1, p2));
            Console.WriteLine();

            // Save and Load Paths
            Path path1 = new Path();
            path1.AddPoint(3, 4, 5);
            path1.AddPoint(1, 1, 1);
            PathStorage.SavePath(path1, false);

            Path path2 = new Path();
            path2.AddPoint(6, 8, 6);
            path2.AddPoint(1, 2, 3);
            PathStorage.SavePath(path2, true);

            Console.WriteLine(PathStorage.LoadPath());
        }
    }
}
