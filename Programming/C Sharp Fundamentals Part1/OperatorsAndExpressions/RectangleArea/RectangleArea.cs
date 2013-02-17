using System;

class RectangleArea
{
    static void Main()
    {
        float width = 0.0f;
        float height = 0.0f;
        float rectangleArea = 0.0f;
       
        while (true)
        {
            Console.Write("Enter rectangle's width: ");
            string stringWidth = Console.ReadLine();

            if (float.TryParse(stringWidth, out width))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
        while (true)
        {
            Console.Write("Enter rectangle's height: ");
            string stringHeight = Console.ReadLine();

            if (float.TryParse(stringHeight, out height))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        rectangleArea = width * height;
        Console.WriteLine("The area of a reactangle with 'width = {0}' and 'height = {1}' is {2}", width, height, rectangleArea);
    }
}