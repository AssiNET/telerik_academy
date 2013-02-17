/*
 * Write methods that calculate the surface of a triangle by given:
 *      -Side and an altitude to it; 
 *      -Three sides; 
 *      -Two sides and an angle between them. 
 * 
 * Use System.Math.
 */

using System;

namespace Problem4SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TriangleSurfaceThreeSides(4, 5, 8));
            Console.WriteLine(TriangleSurfaceSideandHeight(4, 5));
            Console.WriteLine(TriangleSurfaceTwoSideAndAngle(4, 5, 45.0));
        }

        static double TriangleSurfaceThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2; 
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }

        static double TriangleSurfaceSideandHeight(double a, double hA)
        {
            double s = (a * hA) / 2;

            return s;
        }

        static double TriangleSurfaceTwoSideAndAngle(double a, double b, double alpha)
        {
            double s = (a * b * Math.Sin(Math.PI * alpha / 180)) / 2d;

            return s;
        }
    }
}
