using System;

class ModifyValueOfBit
{
    static void Main()
    {
        int n = 5;
        int v = 1;
        int p = 3;

        if (v == 1)
        {
            Console.WriteLine("The value of 'n' is {0} -> {1}", n, Convert.ToString(n, toBase: 2).PadLeft(32, '0'));
            int mask = 1 << p;              
            n = n | mask;
            Console.WriteLine();
            Console.WriteLine("After modification of bit p={0} with v={1}", p, v);
            Console.WriteLine();
            Console.WriteLine("The value of 'n' is {0} -> {1}", n, Convert.ToString(n, toBase: 2).PadLeft(32, '0'));
        }
        else if (v == 0)
        {
            int mask = ~(1 << p);           
            n = n & mask;
            Console.WriteLine();
            Console.WriteLine("After modification of bit p={0} with v={1}", p, v);
            Console.WriteLine();
            Console.WriteLine("The value of 'n' is {0} -> {1}", n, Convert.ToString(n, toBase: 2).PadLeft(32, '0'));
        } 
        else if(v < 0 && v > 1)
            Console.WriteLine("Wrong value for 'v'! It must be 0 or 1.");
    }
}

