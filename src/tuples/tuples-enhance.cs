using System;
using static Color.ColorChange;
using static System.Console;
using static utility.description;

public static class TuplesEnhance
{
    private static string descr = getDescriptions("Tuples");
    public static SoccerTeam st = new SoccerTeam("Milan", 18);
    public static SoccerTeam stDeep = new SoccerTeam("Milan", "San Siro", 18, 1899);

    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    internal static (string name, int pennant) getInfoSoccerTeam()
    {
        (string name, int pennant) = st;
        return (name, pennant);
    }

    internal static (string name, string stadium, int pennant, int founded) getInfoSoccerTeamInDepth()
    {
        (string name, string stadium, int pennant, int founded) = stDeep;
        return (name, stadium, pennant, founded);
    }

    internal static (int sum, int diff, int mult, double div) calculateAB(int a, int b)
    {
        return (a + b, a - b, a * b, (double)a / b);
    }

    internal static (int, int, int, double) calculateABNoSemantic(int a, int b)
    {
        return (a + b, a - b, a * b, (double)a / b);
    }

    public static void testsAssignment()
    {
        var named = calculateAB(10, 1);
        var unnamed = calculateABNoSemantic(10, 5);

        Console.WriteLine($"{named.sum}");
        named = unnamed;
        Console.WriteLine($"{named.sum}");

        (int s, int df, int m, double dv) diffName = calculateAB(9, 3);
        // The field names are not assigned.
        named = diffName;
        Console.WriteLine($"{named.sum}");
    }
}