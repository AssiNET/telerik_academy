using System;

class CardsDeck
{
    static void Main()
    {
        for (byte suit = 1; suit <= 4; suit++)
        {
            for (int value = 1; value <= 13; value++)
            {
                switch (value)
                {
                    case 1:
                        Console.Write("Deuce of ");
                        break;
                    case 2:
                        Console.Write("Three of ");
                        break;
                    case 3:
                        Console.Write("Four of ");
                        break;
                    case 4:
                        Console.Write("Five of ");
                        break;
                    case 5:
                        Console.Write("Six of ");
                        break;
                    case 6:
                        Console.Write("Seven of ");
                        break;
                    case 7:
                        Console.Write("Eight of ");
                        break;
                    case 8:
                        Console.Write("Nine of ");
                        break;
                    case 9:
                        Console.Write("Ten of ");
                        break;
                    case 10:
                        Console.Write("Jack of ");
                        break;
                    case 11:
                        Console.Write("Queen of ");
                        break;
                    case 12:
                        Console.Write("King of ");
                        break;
                    case 13:
                        Console.Write("Ace of ");
                        break;
                    default:
                        break;
                }

                switch (suit)
                {
                    case 1:
                        Console.Write("Spades");
                        break;
                    case 2:
                        Console.Write("Hearts");
                        break;
                    case 3:
                        Console.Write("Diamonds");
                        break;
                    case 4:
                        Console.Write("Clubs");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
