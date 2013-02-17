using System;

class SwapBitSequence
{
    static uint number = 127;
    static int startingBitP = 0;
    static int startingBitQ = 0;
    static int sequenceLength = 3;

    static uint GetAndShiftBitRight(uint number, int position, int numberOfShifts)
    {
        uint mask = (uint)1 << position;
        uint numberAndMask = number & mask;
        uint bit = numberAndMask >> numberOfShifts;
        return bit;
    }

    static uint GetAndShiftBitLeft(uint number, int position, int numberOfShifts)
    {
        uint mask = (uint)1 << position;
        uint numberAndMask = number & mask;
        uint bit = numberAndMask << numberOfShifts;
        return bit;
    }

    static uint SetBitToZero(uint number, int position)
    {
        uint mask = (uint)~(1 << position);
        number = number & mask;
        return number;
    }

    static uint SwapBits(uint number, int firstBitPosition, int secondBitPosition)
    {
        uint firstBitValue = GetAndShiftBitLeft(number, firstBitPosition, secondBitPosition - firstBitPosition);
        uint secondBitValue = GetAndShiftBitRight(number, secondBitPosition, secondBitPosition - firstBitPosition);

        number = SetBitToZero(number, firstBitPosition);
        number = SetBitToZero(number, secondBitPosition);
        number = number | secondBitValue;
        number = number | firstBitValue;

        return number;
    }

    static void Main()
    {
        Console.Write(number + " = ");
        Console.WriteLine(Convert.ToString(number, toBase: 2).PadLeft(32, '0'));
        for (startingBitP = 3, startingBitQ = 24; sequenceLength > 0; startingBitP++, startingBitQ++, sequenceLength--)
        {
            checked
            {
                number = SwapBits(number, startingBitP, startingBitQ);
            }
        }
        Console.Write(number + " = ");
        Console.WriteLine(Convert.ToString(number, toBase: 2).PadLeft(32, '0'));
    }
}
