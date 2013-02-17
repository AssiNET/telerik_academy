using System;

class ExaminesTwoInt
{
    static void Main()
    {
        int a = 5;
        int b = 4;
        int temp = 0;

        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine();
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
        }
        else if (a < b)
        {
            Console.WriteLine("a < b");
        }
        else
        {
            Console.Write(" a = b");
        }
    }
}
