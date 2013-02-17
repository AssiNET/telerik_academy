using System;

class IntInHexFormat
{
    static void Main()
    {
        int value = 0xFE;
        Console.WriteLine("{0} -> 0x{1}", value, Convert.ToString(value, toBase:16).ToUpperInvariant());
    }
}

