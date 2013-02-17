using System;

class ShowsNameOfDigit
{
    static void Main()
    {
        uint digit = 0;
        while (true)
        {
            Console.Write("Enter a digit between [0-9]: ");
            if (uint.TryParse(Console.ReadLine(), out digit) && digit <= 9)
            {
                switch (digit)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:
                        Console.WriteLine("Zero");
                        break;
                }
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        
    }
}

