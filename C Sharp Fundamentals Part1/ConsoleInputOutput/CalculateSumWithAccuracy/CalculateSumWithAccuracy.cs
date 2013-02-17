using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        double finalSum = 0.0d;
        double previousSum = 0.0d;
        double currentSum = 1.0d;
        double index = 1.0d;
        double accuracy = 0.001d;

        do
        {
            previousSum = currentSum;
            index++;
            if (index % 2 == 0)
            {
                currentSum = previousSum + (1 / index);
                finalSum = currentSum;
                Console.WriteLine("Previous sum : {0}", previousSum);
                Console.WriteLine("Final sum : {0}", finalSum);
                Console.WriteLine();
            }
            else
            {
                currentSum = previousSum - (1 / index);
                finalSum = currentSum;
                Console.WriteLine("Previous sum : {0}", previousSum);
                Console.WriteLine("Final sum : {0}", finalSum);
                Console.WriteLine();
            }
        }
        while (Math.Abs(finalSum - previousSum) >= accuracy);

        Console.WriteLine("The sum with accuracy 0.001 is {0}", previousSum);
    }
}