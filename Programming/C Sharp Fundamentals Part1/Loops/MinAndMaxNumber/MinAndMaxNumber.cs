using System;

class MinAndMaxNumber
{
    static uint GetMaxValue(uint[] arr)
    {
        int i = 0;
        uint MaxValue = arr[i];
        for (i = 0; i < arr.Length; i++)
		{
            if (arr[i] > MaxValue)
            {
                MaxValue = arr[i];
            }
		}
        return MaxValue;
    }

    static uint GetMinValue(uint[] arr)
    {
        int i = 0;
        uint MinValue = arr[i];
        for (i = 0; i < arr.Length; i++)
		{
            if (arr[i] < MinValue)
            {
                MinValue = arr[i];
            }
		}
        return MinValue;
    }

    static void Main()
    {
        uint number = 0;
        string strNumber = null;
        while (true)
        {
            Console.Write("Enter number: ");
            strNumber = Console.ReadLine();
            if (uint.TryParse(strNumber, out number))
            {
                break;
            }
            else
	        {
                Console.WriteLine("Wrong input!!!");
	        }
        }

        uint[] arrNumbers = new uint[number];
        uint n = 0;
        string strN = null;

        for (int i = 0; i < number; i++)
        {
            while (true)
            {
                strN = Console.ReadLine();
                if (uint.TryParse(strN, out n))
                {
                    arrNumbers[i] = n;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input!!!");
                }
            }
        }
        uint MaxValue = GetMaxValue(arrNumbers);
        Console.WriteLine("Max value of the sequence is {0}", MaxValue);

        uint MinValue = GetMinValue(arrNumbers);
        Console.WriteLine("Min value of the sequence is {0}", MinValue);
    }
}