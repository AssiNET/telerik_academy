using System;
using System.Text;

class ConvertNumberToText
{
    static string GetUnits(uint number)
    {
        string unit = null;
        switch (number)
        {
            case 0:
                unit = "Zero";
                break;
            case 1:
                unit = "One";
                break;
            case 2:
                unit = "Two";
                break;
            case 3:
                unit = "Three";
                break;
            case 4:
                unit = "Four";
                break;
            case 5:
                unit = "Five";
                break;
            case 6:
                unit = "Six";
                break;
            case 7:
                unit = "Seven";
                break;
            case 8:
                unit = "Eight";
                break;
            case 9:
                unit = "Nine";
                break;
            default:
                break;
        }
        return unit;
    }

    static string GetSpecialCases(uint number)
    {
        string specialNumber = null;
        if (number >= 10 && number <= 19)
        {
            switch (number)
            {
                case 10:
                    specialNumber = "Ten";
                    break;
                case 11:
                    specialNumber = "Eleven";
                    break;
                case 12:
                    specialNumber = "Twelve";
                    break;
                case 13:
                    specialNumber = "Thirteen";
                    break;
                case 14:
                    specialNumber = "Fourteen";
                    break;
                case 15:
                    specialNumber = "Fifteen";
                    break;
                case 16:
                    specialNumber = "Sixteen";
                    break;
                case 17:
                    specialNumber = "Seventeen";
                    break;
                case 18:
                    specialNumber = "Eighteen";
                    break;
                case 19:
                    specialNumber = "Nineteen";
                    break;
                default:
                    break;
            }
        }
        return specialNumber;
    }

    static string GetTenths(uint number)
    {
        string tenth = null;
        if (number >= 2 && number <= 9)
        {
            switch (number)
            {
                case 2:
                    tenth = "Twenty";
                    break;
                case 3:
                    tenth = "Thirty";
                    break;
                case 4:
                    tenth = "Forty";
                    break;
                case 5:
                    tenth = "Fifty";
                    break;
                case 6:
                    tenth = "Sixty";
                    break;
                case 7:
                    tenth = "Seventy";
                    break;
                case 8:
                    tenth = "Eighty";
                    break;
                case 9:
                    tenth = "Ninety";
                    break;
                default:
                    break;
            }
        }
        return tenth;
    }

    static void Main()
    {
        uint number = 0u;
        uint digitsNumber = 0u;
        string numberAsText = null;
        uint unitDigit = 0u;
        uint tenthDigit = 0u;
        uint hundredDigit = 0u;

        while (true)
        {
            Console.Write("Enter integer number between [0 - 999]: ");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out number) && number <= 999)
            {
                digitsNumber = (uint)number.ToString().Length;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        switch (digitsNumber)
        {
            case 1:
                numberAsText = GetUnits(number);
                break;
            case 2:
                if (number >= 10 && number <= 19)
                {
                    numberAsText = GetSpecialCases(number);
                }
                else if (number >= 20 && number <= 99)
                {
                    if (number % 10 == 0)
                    {
                        tenthDigit = number / 10;
                        numberAsText = GetTenths(tenthDigit);
                    }
                    else if (number % 10 != 0)
                    {
                        unitDigit = number % 10;
                        tenthDigit = number / 10;
                        numberAsText = GetTenths(tenthDigit) + " " + GetUnits(unitDigit);
                    }
                }
                break;
            case 3:
                if (number % 10 == 0)
                {
                    if ((number / 10) % 10 == 0)
                    {
                        hundredDigit = number / 100;
                        numberAsText = GetUnits(hundredDigit) + " Hundred";
                    }
                    else if ((number / 10) % 10 > 0 && (number / 10) % 10 <= 9)
                    {
                        hundredDigit = number / 100;
                        tenthDigit = (number / 10) % 10;
                        numberAsText = GetUnits(hundredDigit) + " Hundred and " + GetTenths(tenthDigit);
                    }
                }
                else if (number % 10 >= 0 && number % 10 <= 9 && (number / 10) % 10 == 1)
                {
                    hundredDigit = number / 100;
                    tenthDigit = number % 100;
                    numberAsText = GetUnits(hundredDigit) + " Hundred and " + GetSpecialCases(tenthDigit);
                }
                else if (number % 10 > 0 && number % 10 <= 9)
                {
                    if ((number / 10) % 10 == 0)
                    {
                        hundredDigit = number / 100;
                        unitDigit = number % 10;
                        numberAsText = GetUnits(hundredDigit) + " Hundred and " + GetUnits(unitDigit);
                    }
                    else if ((number / 10) % 10 >= 2 && (number / 10) % 10 <= 9)
                    {
                        hundredDigit = number / 100;
                        tenthDigit = (number / 10) % 10;
                        unitDigit = number % 10;
                        numberAsText = GetUnits(hundredDigit) + " Hundred and " + GetTenths(tenthDigit) + " " + GetUnits(unitDigit);
                    }
                }
                break;
            default:
                break;
        }
        Console.WriteLine(numberAsText);
    }
}