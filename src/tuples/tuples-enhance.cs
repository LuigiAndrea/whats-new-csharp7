using System;
using static Color.ColorChange;
using static System.Console;

public class TuplesEnhance
{
    private string descr { get; set; }
    public SoccerTeam st { get; set; }
    public SoccerTeam stDeep { get; set; }
    public TuplesEnhance()
    {
        descr = $"Improved the efficiency and language support for tuples (enables semantic names) Look the source code for examples on \n1. Syntax, tuple and assignment \n2. return multiple values \n3. Deconstruct and Extensions";
        st = new SoccerTeam("Milan", 18);
        stDeep = new SoccerTeam("Milan", "San Siro", 18, 1899);
    }

    public void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    internal (string name, int pennant) getInfoSoccerTeam()
    {
        (string name, int pennant) = this.st;
        return (name, pennant);
    }

    internal (string name, string stadium, int pennant, int founded) getInfoSoccerTeamInDepth()
    {
        (string name, string stadium, int pennant, int founded) = this.stDeep;
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