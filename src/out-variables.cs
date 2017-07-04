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

    public void discardParameters()
    {
        incDec(2, out _, out int d);
        WriteLine(d);
    }
    public void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
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

    private void incDec(int num, out int inc, out int dec)
    {
        inc = num + 1;
        dec = num - 1;
    }
}