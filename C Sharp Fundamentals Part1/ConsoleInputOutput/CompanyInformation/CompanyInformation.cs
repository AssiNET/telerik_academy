using System;

class CompanyInformation
{
    static void Main()
    {
        string companyAddress = "ul. Telerik 14";
        string companyName = "Company Ltd.";
        ulong companyPhone = 359888776655u;
        ulong companyFax = 12345678910u;
        string companyWebsite = "www.website.com";
        string managerFirstName = "Krasimir";
        string managerLastName = "Krustev";
        ulong managerPhone = 359888995544u;
        byte managerAge = 26;
        string companyManager = managerFirstName + " " + managerLastName;

        Console.WriteLine();
        Console.WriteLine("Company Information");
        Console.WriteLine("--------------------");
        Console.WriteLine("Company name: {0, -15}", companyName);
        Console.WriteLine("Address: {0, -15}", companyAddress);
        Console.WriteLine("Phone number: {0, -15}", companyPhone);
        Console.WriteLine("Fax number: {0, -15}", companyFax);
        Console.WriteLine("Website: {0, -15}", companyWebsite);
        Console.WriteLine("Manager: {0, -15}", companyManager);

        Console.WriteLine();
        Console.WriteLine("Manager Information");
        Console.WriteLine("-------------------");
        Console.WriteLine("First name: {0, -15}", managerFirstName);
        Console.WriteLine("Last name: {0, -15}", managerLastName);
        Console.WriteLine("Age: {0, -15}", managerAge);
        Console.WriteLine("Phone number: {0, -15}", managerPhone);
        Console.WriteLine();
    }
}

