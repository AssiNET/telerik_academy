﻿/*
 * Write a program that generates and prints to the console
 * 10 random values in the range [100, 200].
 */

using System;

namespace Problem2RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(0, 100) + 100);
            }
        }
    }
}
