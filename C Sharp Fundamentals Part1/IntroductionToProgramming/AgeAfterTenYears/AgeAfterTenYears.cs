using System;

class AgeAfterTenYears
{
    static void Main()
    {
        byte currentAge = 0;
        while (true)
        {
            Console.Write("Your current age: ");
            if (byte.TryParse(Console.ReadLine(), out currentAge) && currentAge <= 245)
            {
                DateTime currentYear = new DateTime(DateTime.Today.Year);
                DateTime afterTenYears = currentYear.AddYears(10);
                byte ageTenYearsLater = (byte)(currentAge + (afterTenYears.Year - currentYear.Year));

                Console.WriteLine("10 years later you will be {0}", ageTenYearsLater + " years old.");
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }
}

