using static System.Console;
using System;
using static Color.ColorChange;
using static utility.description;

public static class SwitchPattern
{
    private static string descr = getDescriptions("SwitchPattern");

    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    public static void printTypeAndValue(object x)
    {
        switch (x)
        {
            case 0:
                WriteLine("Special case of int (0)");
                break;
            case int i when i < 10:
                WriteLine($"int {i} (less than 10)");
                break;
            case int i:
                WriteLine($"int {i}");
                break;
            case string s:
                WriteLine($"string {s} with length {s.Length}");
                break;
            case bool b:
                WriteLine("Boolean True");
                break;
            case null:
                WriteLine("null");
                break;
            case myType mt:
                WriteLine($"myType {mt.Name} with length {mt.Value}");
                break;
            default:
                throw new InvalidOperationException("unknown item type");
        }
    }
}

internal class myType
{
    public string Name { get; set; }
    public int Value { get; }

    public myType(string name)
    {
        Name = name;
        Value = name.Length;
    }
}