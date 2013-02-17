using System;

class ObjectToStringCast
    {
        static void Main()
        {
            string strHello = "Hello";
            string strWorld = "World";
            string strHelloWorld = null;

            object objHelloWorld = strHello + " " + strWorld;

            if (objHelloWorld is string)
            {
                strHelloWorld = (string)objHelloWorld;
            }

            Console.WriteLine("string strHello = {0}\n", strHello);

            Console.WriteLine("string strWorld = {0}\n", strWorld);

            Console.WriteLine("object objHelloWorld = {0}\n", objHelloWorld);

            Console.WriteLine("string strHelloWorld = {0}\n", strHelloWorld);
        }
    }

