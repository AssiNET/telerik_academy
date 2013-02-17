using System;
using System.Collections.Generic;
using System.Threading;

struct Figure
{
    public int currentPositionX;
    public int currentPositionY;
    public ConsoleColor color;
    public string figure;
}

class FallingRocks
{
    //Creating random generator
    static Random generator = new Random();

    static ConsoleColor[] color = 
    { 
        ConsoleColor.Blue, 
        ConsoleColor.Cyan, 
        ConsoleColor.Magenta, 
        ConsoleColor.Green, 
        ConsoleColor.Yellow, 
        ConsoleColor.DarkMagenta, 
        ConsoleColor.DarkGray
    };

    static char[] rockCharacter = 
    { 
        '^', '&', '@', '*', '+', '%', '$', '#', '!', '.', ';' 
    };

    //Print at position (x,y)
    static void PrintAtPosition(int x, int y, string figure, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(figure);
    }

    static void Main()
    {
        DateTime startTime = new DateTime();
        startTime = DateTime.Now;

        char[] dwarfSymbols = new char[3]
            {
                '(','0',')'
            };

        Console.CursorVisible = false;

        //Clearing ScrollBars
        Console.BufferHeight = Console.WindowHeight = 15;
        Console.BufferWidth = Console.WindowWidth = 30;

        //Initial position of the dwarf
        Figure dwarf = new Figure();
        dwarf.currentPositionX = 6;
        dwarf.currentPositionY = 14;

        for (int i = 0; i < dwarfSymbols.Length; i++)
        {
            dwarf.figure += dwarfSymbols[i];
        }
        dwarf.color = ConsoleColor.DarkGray;

        //Creating list for the rocks
        List<Figure> rocks = new List<Figure>();

        while (true)
        {

            //Creating rock
            Figure rock = new Figure();
            rock.currentPositionX = generator.Next(1, 30);
            rock.currentPositionY = 1;
            rock.color = color[generator.Next(0, 7)];

            for (int i = 0; i < 1; i++)
            {
                rock.figure += rockCharacter[generator.Next(0, 11)];
            }
            rocks.Add(rock);

            //Block the console if a key has been pressed
            if (Console.KeyAvailable)
            {
                //Check which key has been pressed
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                //Smoothing the dwarf's motion
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                //Move the dwarf
                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (dwarf.currentPositionX - 1 >= 1)
                        {
                            dwarf.currentPositionX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (dwarf.currentPositionX + 1 < 27)
                        {
                            dwarf.currentPositionX++;
                        }
                        break;
                    default:
                        break;
                }
            }

            //Creating a new list for rocks with changed Y coordinate
            List<Figure> newRocks = new List<Figure>();

            //Moving the rocks
            for (int i = 0; i < rocks.Count; i++)
            {
                Figure newRock = rocks[i];
                newRock.currentPositionY = newRock.currentPositionY + 1;

                //Check if the rock hit the dwarf
                if ((newRock.currentPositionX == dwarf.currentPositionX && newRock.currentPositionY == dwarf.currentPositionY) ||
                    (newRock.currentPositionX == dwarf.currentPositionX + 1 && newRock.currentPositionY == dwarf.currentPositionY) ||
                    (newRock.currentPositionX == dwarf.currentPositionX + 2 && newRock.currentPositionY == dwarf.currentPositionY))
                {
                    DateTime endTime = new DateTime();
                    endTime = DateTime.Now;
                    double finalTime = endTime.TimeOfDay.TotalSeconds - startTime.TimeOfDay.TotalSeconds;
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!!! \nYour score is: {0}\n", (int)(finalTime));
                    return;
                }

                //Check whether the rock has not reached the bottom of the playfield
                if (newRock.currentPositionY < 15)
                {
                    newRocks.Add(newRock);
                }

            }
            rocks = newRocks;

            //Clearing the whole Console
            Console.Clear();

            //Drawing the dwarf
            PrintAtPosition(dwarf.currentPositionX, dwarf.currentPositionY, dwarf.figure, dwarf.color);

            //Draw the rocks
            foreach (Figure rocksItem in rocks)
            {
                PrintAtPosition(rocksItem.currentPositionX, rocksItem.currentPositionY, rocksItem.figure, rocksItem.color);
            }

            //Slowing down the application
            Thread.Sleep(150);
        }
    }
}
