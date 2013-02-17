using System;
using System.Globalization;
using System.Threading;

class QuadraticEcuation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = 0.0d;
        double b = 0.0d;
        double c = 0.0d;
        double determinant = 0.0d;
        double x1 = 0.0d;
        double x2 = 0.0d;

        while (true)
        {
            Console.Write("Enter value for 'a': ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Wrong input");
            }
            else
                break;
        }

        while (true)
        {
            Console.Write("Enter value for 'b': ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Wrong input");
            }
            else
                break;
        }

        while (true)
        {
            Console.Write("Enter value for 'c': ");
            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Wrong input");
            }
            else
                break;
        }

        if (a == 0)
        {
            Console.WriteLine("The equation is linear!");
        }
        else
        {
            determinant = b * b - 4 * a * c;

            if (determinant > 0)
            {
                x1 = (-b - Math.Sqrt(determinant)) / 2 * a;
                x2 = (-b + Math.Sqrt(determinant)) / 2 * a;
                Console.WriteLine("The determinant is positive.");
                Console.WriteLine("The equation has two real roots x1 = {0:F2} and x2 = {1:F2}", x1, x2);
            }

            else if (determinant == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("The determinant is equal to 0.");
                Console.WriteLine("The equation has two real root x1 = x2 = {0:F2}", x1);
            }

            else if (determinant < 0)
            {
                Console.WriteLine("The determinant is negative.");
                Console.WriteLine("The equation hasn't real roots!");
            }
        }
    }
}

