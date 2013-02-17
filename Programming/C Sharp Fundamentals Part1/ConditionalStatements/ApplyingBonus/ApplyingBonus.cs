using System;

class ApplyingBonus
{
    static void Main()
    {
        uint digit = 0;
        string input = null;

        while (true)
        {
            Console.Write("Enter a digit from in the interval [1 - 9]: ");
            input = Console.ReadLine();
            if (uint.TryParse(input, out digit) && digit <= 9)
            {
                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                        digit *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        digit *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        digit *= 1000;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(digit);
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }
}
