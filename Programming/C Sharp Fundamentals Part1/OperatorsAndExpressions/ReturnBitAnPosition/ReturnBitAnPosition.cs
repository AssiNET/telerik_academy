using System;

class ReturnBitAtPosition
{
    static void Main()
    {
        int v = 5;
        int p = 1;
        int mask = 1 << p;
        int bitwiseAnd = v & mask;
        int bit = bitwiseAnd >> p;

        Console.WriteLine("v = {0} ({1})", v, Convert.ToString(v, 2).PadLeft(32, '0'));
        Console.Write("Bit at p = {0} -> ", p);
        Console.WriteLine((bit == 1) ? (bit == 1) : (bit == 1));
    }
}

