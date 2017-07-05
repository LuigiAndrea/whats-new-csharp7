using static System.Console;
using System;
using static Color.ColorChange;
using static utility.description;
public static class OutVariable
{
    private const string Input = "1000";
    private static string descr = getDescriptions("OutVariable");

    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }
    internal static int? convertStringToInt()
    {
        int num;
        if (int.TryParse("1000", out num))
            return num;
        else
            WriteLine("Could not parse the number");

        return null;
    }

    internal static int? convertStringToIntNOW()
    {
        if (int.TryParse(Input, out int result))
            WriteLine(result);
        else
            WriteLine("Could not parse the number");

        return null;
    }

    internal static void discardParameters()
    {
        incDec(2, out _, out int d);
        WriteLine(d);
    }
    private static void incDec(int num, out int inc, out int dec)
    {
        inc = num + 1;
        dec = num - 1;
    }
}