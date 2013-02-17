using System;

class CalculateSumS
{
    static void Main()
    {
        uint n = 0u;
        uint x = 0u;
        double sum = 1.0d;
        double sumItem = 1;
 
        while (true)
        {
            Console.Write("Enter positive value for n: ");
            if (uint.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        while (true)
        {
            Console.Write("Enter positive value for x: ");
            if (uint.TryParse(Console.ReadLine(), out x) && x > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        
        for (uint i = 1; i <= n; i++)
        {
            sumItem = (sumItem * i) / x;
            sum += sumItem;  
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}