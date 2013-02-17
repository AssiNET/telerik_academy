using System;

class PrintInterval
{
    static void Main()
    {
        int number = 0;
        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }

        Console.WriteLine("Numbers in interval [{0}, {1}]", 1, number);
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

