using System;

class TrapezoidArea
{
    static bool isVariableValid = false;

    static float ValidateVariable(string input)
    {
        float floatValue = 0.0f;
        if (float.TryParse(input, out floatValue))
        {
            isVariableValid = true;
        }
        else
        {
            Console.WriteLine("Wrong input!!!\n");   
        }
        return floatValue;
    }

    static void Main()
    {
        float topBase = 0.0f;
        float bottomBase = 0.0f;
        float height = 0.0f;
        float trapezoidArea = 0.0f;

        while (isVariableValid == false)
        {
            Console.Write("Enter trapezoid's top-base: ");
            topBase = ValidateVariable(Console.ReadLine());
            Console.WriteLine();
        }

        isVariableValid = false;

        while (isVariableValid == false)
        {
            Console.Write("Enter trapezoid's bottom-base: ");
            bottomBase = ValidateVariable(Console.ReadLine());
            Console.WriteLine();
        }

        isVariableValid = false;

        while (isVariableValid == false)
        {
            Console.Write("Enter trapezoid's height: ");
            height = ValidateVariable(Console.ReadLine());
            Console.WriteLine();
        }

        trapezoidArea = ((topBase + bottomBase) / 2) * height;
        Console.WriteLine("The area of a trapezoid is {0} with \n'top-base' = {1}, 'bottom-base' = {2} and 'height' = {3}", trapezoidArea, topBase, bottomBase, height);
    }
}

