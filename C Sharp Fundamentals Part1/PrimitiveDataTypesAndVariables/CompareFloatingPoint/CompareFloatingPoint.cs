using System;

class CompareFloatingPoint
{
    static void CompareFloatPoint(float number1, float number2)
    {
        Console.WriteLine((Math.Abs(number1 - number2) < 0.000001) ? "The two numbers are even!" : "The two numbers are not even!");
    }

    static void Main()
    {
        Console.WriteLine("Comparing {0} and {1}", "5.01", "6.3");
        CompareFloatPoint(5.01f, 6.3f);
        Console.WriteLine( );
        Console.WriteLine("Comparing {0} and {1}", "5.00000001", "5.00000003");
        CompareFloatPoint(5.00000001f, 5.00000003f);
        Console.WriteLine();
    }
}

