using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName = "Krasimir"; 
        string familyName = "Krustev";
        byte age = 26;
        char gender = 'm';
        ulong idNumber = 8611170000u;
        ushort employeeID = 9999;
        uint uniqueEmployeeNumber = 27560000 + (uint)employeeID;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Family Name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);

    }
}

