using System;

class ThirdBit
{
    static void Main()
    {
        int number = 8; // 1000
        int p = 3;
        int mask = 1 << p;
        int bit = (number & mask) >> p;

        Console.WriteLine((bit == 1) ? "The third bit of number {0} in his binary representation \n{1} \nis 1":
                                       "The third bit of number {0} in his binary representation \n{1} \nis 0", 
                            number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

