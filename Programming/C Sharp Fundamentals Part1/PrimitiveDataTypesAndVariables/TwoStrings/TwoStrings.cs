using System;

class TwoStrings
{
    static void Main()
    {
        // String quotation using escaping sequence
        string stringSequence1 = "The \"use\" of quotations causes difficulties.";
        
        // String quotation using @ quatation
        string stringSequence2 = @"The ""use"" of quotations causes difficulties."; 
        
        Console.WriteLine(stringSequence1 + "\n\n" + stringSequence2);
    }
}

