using static System.Console;
using System;
using static Color.ColorChange;

public class OutVariable
{
    public const string Input = "1000";
    public string descr { get; set; }
    public OutVariable()
    {
        descr = "From C# 7, you can declare variables on the fly when calling methods with out parameters";
    }

    public void description()
    {
        WriteLineWithColor($"\n{descr}",ConsoleColor.Green);
    }
    internal int? convertStringToInt()
    {
        int num;
        if (int.TryParse("1000", out num))
            return num;
        else
            WriteLine("Could not parse the number");

        return null;
    }

    internal int? convertStringToIntNOW()
    {
        if (int.TryParse(Input, out int result))
            WriteLine(result);
        else
            WriteLine("Could not parse the number");

        return null;
    }
}