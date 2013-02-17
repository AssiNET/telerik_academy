using System;
using System.Numerics;

class FibonacciLoop
{
    static void Main()
    {
        BigInteger previousNumber = 0;
        BigInteger currentNumber = 1;
        BigInteger nextNumber = 0;

        Console.WriteLine("{0}{1, 15}", "Index", "Number");
        Console.WriteLine("----------------------");
        Console.WriteLine("{0, -16}{1}", "1", previousNumber);
        Console.WriteLine("{0, -16}{1}", "2", currentNumber);

        for (byte i = 3; i <= 100; i++)
        {
            nextNumber = previousNumber + currentNumber;
            Console.WriteLine("{0, -16}{1}", i, nextNumber);
            previousNumber = currentNumber;
            currentNumber = nextNumber;
        }   
    }
}

