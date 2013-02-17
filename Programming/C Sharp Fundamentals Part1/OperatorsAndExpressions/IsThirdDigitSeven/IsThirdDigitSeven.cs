using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int number = 1732;
        int thirdDigit = number;
        thirdDigit /= 100;
        thirdDigit %= 10;

        if (thirdDigit % 7 == 0)
        {
            Console.WriteLine(number + " -> " + thirdDigit);    
        }
        
    }
}

