using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        float radius = 0.0f;
        double perimeter = 0.0d;
        double area = 0.0d;

        while (true)
        {
            Console.Write("Enter a radius of a circle: ");
            if (float.TryParse(Console.ReadLine(), out radius))
            {
                area = Math.PI * (radius * radius);
                perimeter = 2 * Math.PI * radius;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        
        Console.WriteLine("\nThe radius of the circle is {0}\n", radius);
        Console.WriteLine("The area of circle is {0:0.000}\n", area);
        Console.WriteLine("The perimeter of circle is {0:0.000}", perimeter);
    }
}

