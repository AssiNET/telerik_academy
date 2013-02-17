using System;

class ReadThreeNumbers
{
    static void Main()
    {
        int number = 0;
        int sum = 0;

        while (true)
        {
            Console.Write("Enter first number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                sum += number;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input type.");
            }
        }

        while (true)
        {
            Console.Write("Enter second number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                sum += number;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input type.");
            }
        }

        while (true)
        {
            Console.Write("Enter third number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                sum += number;
                Console.WriteLine("\nThe sum of the three numbers is {0}", sum);
                break;
            }
            else
            {
                Console.WriteLine("Wrong input type.");
            }
        }

    }
}
