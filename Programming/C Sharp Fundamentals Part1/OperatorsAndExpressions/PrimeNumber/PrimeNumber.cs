using System;

class PrimeNumber
{
    static void Main()
    {
        uint num = 0;
        while (true)
        {
            Console.Write("Enter a positive number: ");
            if (uint.TryParse(Console.ReadLine(), out num))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        
        uint divider = 2u;
        uint maxDivider = (uint)Math.Sqrt(num);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (num % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Number {0} is {1}", num, prime);
    }
}