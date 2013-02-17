using System;

class FloatOrDouble
{
    static void Main()
    {
        float floatVariableOne = 12.345f;
        float floatVariableTwo = 3456.091f;
        double doubleVariableOne = 34.567839023d;
        double doubleVariableTwo = 8923.1234857d;

        Console.WriteLine("The float variables are:\n{0} and {1}\n", floatVariableOne, floatVariableTwo);
        Console.WriteLine("The double variables are:\n{0} and {1}", doubleVariableOne, doubleVariableTwo);
    }
}
