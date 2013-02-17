using System;

class GreaterNumber
{
    static void Main()
    {
        //Using IF statement only for validating the input

        double firstNumber = 0.0d;
        double secondNumber = 0.0d;

        while (true)
        {
            Console.Write("Enter first number: ");
            if (double.TryParse(Console.ReadLine(), out firstNumber))
            {
                break;    
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }

        while (true)
        {
            Console.Write("Enter second number: ");
            if (double.TryParse(Console.ReadLine(), out secondNumber))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        Console.WriteLine("Number {0} is greater than number {1}", Math.Max(firstNumber, secondNumber), 
                           Math.Min(firstNumber, secondNumber));
    }
}

