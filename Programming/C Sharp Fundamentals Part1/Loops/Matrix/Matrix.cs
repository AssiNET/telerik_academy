using System;

class Matrix
{
    static void PrintMatrix(byte n)
    {
        byte value = 0;
        for (byte row = 0; row < n; row++)
        {
            for (byte col = row; col < n + row; col++)
            {
                value = (byte)(col + 1);
                Console.Write("{0, 3}", value);
            }
            Console.WriteLine("\n");
        }
    }

    static void Main()
    {
        byte n = 0;

        while (true)
        {
            Console.Write("Enter value between [1 - 19] for n: ");
            if (byte.TryParse(Console.ReadLine(), out n) && n < 20)
            {
                PrintMatrix(n);
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }
}

