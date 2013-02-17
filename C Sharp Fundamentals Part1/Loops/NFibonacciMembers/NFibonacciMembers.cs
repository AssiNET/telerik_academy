using System;

class NFibonacciMembers
{
    static void Main()
    {
        uint n = 5;
        uint previous = 0;
        uint current = 1;
        uint next = 0;
        double sum = 1.0d;

        while (true)
        {
            Console.Write("Enter value for n: ");
            if (uint.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        if (n == 0)
        {
            Console.WriteLine(0);
        }
        else if (n == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (uint member = 3; member <= n; member++)
            {
                next = previous + current;
                sum += next;
                previous = current;
                current = next;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}

