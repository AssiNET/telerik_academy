using System;
using System.Text;

class AsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char sign = '\u0000';
        string displayCharacter = null;

        Console.WriteLine("ASCI Table\n------------------------");
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.WriteLine("HEX".PadRight(10));
        Console.WriteLine("------------------------\n");

        for (int i = 0; i <= 255; i++)
        {
            sign = (char)i;
            if (char.IsWhiteSpace(sign))
            {
                displayCharacter = sign.ToString();
                switch (sign)
                {
                    case '\t':
                        displayCharacter = "\\t";
                        break;
                    case ' ':
                        displayCharacter = "space";
                        break;
                    case '\n':
                        displayCharacter = "\\n";
                        break;
                    case '\r':
                        displayCharacter = "\\r";
                        break;
                    case '\v':
                        displayCharacter = "\\v";
                        break;
                    case '\f':
                        displayCharacter = "\\f";
                        break;
                }
            }
            else if (char.IsControl(sign))
            {
                displayCharacter = "control";
            }
            else
            {
                displayCharacter = sign.ToString();
            }
            
            Console.Write(i.ToString().PadRight(10));
            Console.Write(displayCharacter.PadRight(10));
            Console.Write("\\u00{0}", i.ToString("X2").PadRight(10));
            Console.WriteLine();
        }
    }
}