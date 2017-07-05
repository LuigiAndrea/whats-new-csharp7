using static System.Console;
using System;
using static Color.ColorChange;

public class SwitchPattern
{
    private string descr { get; set; }
    public SwitchPattern()
    {
        descr = "From C# 7, you can switch on an object's type, the order of the case clauses is relevant except for the default clause";
    }
    public void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    public void printTypeAndValue(object x)
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

class myType {
    public string Name { get; set; }
    public  int Value { get; }

    public myType(string name){
        Name = name;
        Value = name.Length;
    }
}