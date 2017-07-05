using System;
using static Color.ColorChange;
using static System.Console;
using static utility.description;
public static class NumericLiteral
{
    private const int binary18 = 0b0001_0010;
    private const string binary18str = "0b0001_0010";
    private const long BillionsAndBillions = 100_000_000_000;
    private const int binary23 = 0b0001_0111;
    private static string descr = getDescriptions("NumericLiteral");
   
    public static int sumBinary()
    {
        return binary18 + binary23;
    }

    public static void description()
    {
        WriteLineWithColor($"\n{descr} --> {binary18str}",ConsoleColor.Green);
    }
}