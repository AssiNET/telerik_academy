using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int symbolsPerRow = 1;
        int rowsNumber = 3;                                                     // the rows' number must be 3, in order to get 9 copyright symbol 
        char symbol = '\u00a9';                                                 // copyright symbol

        // Loop through the rows
        for (int row = 0; row < rowsNumber; row++)
        {
            // Adding whitespaces on the left side of the triangle
            for (int space = rowsNumber - row; space > 1; space--)
            {
                Console.Write(" ");
                Console.Write(" ");
            }

            // Printing the triangle
            for (int charNumber = 1; charNumber <= symbolsPerRow; charNumber++)
            {
                Console.Write(symbol);
                Console.Write(" ");
            }
            symbolsPerRow += 2;                                                  // after the first row, the symbols' number per row grows up with "+2"
            Console.WriteLine();
        }
    }
}

