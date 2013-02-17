using System;

class Problem1_ArrayInitializeElements
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
