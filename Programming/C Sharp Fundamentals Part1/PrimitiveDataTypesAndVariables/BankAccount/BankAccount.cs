using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Krasimir";
        string middleName = "Ivanov";
        string lastName = "Krustev";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 10000.0m;
        string bankName = "DSK Bank";
        string iban = "BGSTSA9300005555555";
        string bicCode = "BGSTSASF";
        ulong cardNumber1 = 123456678910u;
        ulong cardNumber2 = 123456678911u;
        ulong cardNumber3 = 123456678912u;

        Console.WriteLine("Holder name: {0}\n", holderName);
        Console.WriteLine("Account Balance: {0:0} {1}\n", accountBalance, "Euro");
        Console.WriteLine("Bank name: {0}\n", bankName);
        Console.WriteLine("IBAN: {0}\n", iban);
        Console.WriteLine("BIC Code: {0}\n", bicCode);
        Console.WriteLine("Credit card 1: {0}\nCredit card 2: {1}\nCredit card 3: {2}", cardNumber1, cardNumber2, cardNumber3);
        Console.WriteLine();
    }
}

