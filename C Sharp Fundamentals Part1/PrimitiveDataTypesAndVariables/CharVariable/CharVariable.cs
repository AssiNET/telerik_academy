using System;

class CharVariable
{
    static void Main()
    {
        char variable = '\u0048';
        Console.WriteLine("{0} -> 0x{1}", variable, Convert.ToString(variable, toBase: 16).ToUpperInvariant());
    }
}

