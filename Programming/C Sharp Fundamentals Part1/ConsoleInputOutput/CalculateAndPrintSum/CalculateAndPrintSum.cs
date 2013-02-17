using System;

class CalculateAndPrintSum
{
    static void Main()
    {
        int number = 0;
        int sum = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        for (int i = 0; i < number; i++)
        {
            int n = 0;
            while (true)
            {
                Console.Write("Enter number: ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    sum += n;
                    break; 
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}

