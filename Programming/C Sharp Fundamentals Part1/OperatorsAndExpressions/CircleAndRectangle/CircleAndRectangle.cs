using System;

class CircleAndRectangle
{
    static void Main()
    {
        float pointX = 0.0f;
        float pointY = 0.0f;
        
        float circleCenterX = 1.0f;
        float circleCenterY = 1.0f;
        float circleRadius = 3.0f;
        
        float rectangleTopLeftX = -1.0f;
        float rectangleTopLeftY = 1.0f;
        float rectangleWidth = 6.0f;
        float rectangleHeight = 2.0f;

        bool isInCircle = (pointX - circleCenterX) * (pointX - circleCenterX) + (pointY - circleCenterY) * 
            (pointY - circleCenterY) <= circleRadius * circleRadius;

        bool isInRectangle = (pointX >= rectangleTopLeftX & pointX <= rectangleTopLeftX + rectangleWidth & pointY <= rectangleTopLeftY &
          pointY >= rectangleTopLeftY - rectangleHeight);

        if (isInCircle && isInRectangle)
        {
            Console.WriteLine("The point x({0},{1}) is in the circle and in the rectangle!", pointX, pointY);
        }
        else if (isInCircle)
        {
            Console.WriteLine("The point x({0},{1}) is in the circle, but out of the rectangle!", pointX, pointY);
        }
        else //if (isInRectangle)
        {
            Console.WriteLine("The point x({0},{1}) is out of the circle, but in the rectangle!", pointX, pointY);
        }
    }
}

