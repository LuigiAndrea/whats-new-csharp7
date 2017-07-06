using static System.Console;
using System;
using static Color.ColorChange;
using static utility.description;

public static class ExpressionBodied
{
    private static string descr = getDescriptions("Expression");
    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }
}