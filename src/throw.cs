using System;
using static Color.ColorChange;
using static utility.description;
public static class Throw
{
    private static string descr = getDescriptions("Throw");
    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }
}