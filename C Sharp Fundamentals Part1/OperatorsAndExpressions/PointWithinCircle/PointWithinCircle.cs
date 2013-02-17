using System;


class PointWithinCircle
{
    static void Main()
    {
        float radius = 5.0f;
        float pointXCoordinate = 2.0f;
        float pointYCoordinate = 3.0f;

        if ((pointXCoordinate * pointXCoordinate) + (pointYCoordinate * pointYCoordinate) <= radius * radius)
        {
            Console.WriteLine("The point with coordinates ({0},{1}) is in the circle with radius {2}", pointXCoordinate, pointYCoordinate, radius);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0},{1}) is out of the circle with radius {2}", pointXCoordinate, pointYCoordinate, radius);
        }
    }
}

