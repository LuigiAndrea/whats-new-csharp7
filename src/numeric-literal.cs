using static System.Console;
public class NumericLiteral
{
    public const int binary18 = 0b0001_0010;
    public const string binary18str = "0b0001_0010";
    public const long BillionsAndBillions = 100_000_000_000;
    public const int binary23 = 0b0001_0111;
    public string descr { get; set; }
    public NumericLiteral()
    {
        descr = "From C#7 is possible to Use the 0b prefix for binary literals and underscores to improve readability";
    }

    private int sumBinary()
    {
        return binary18 + binary23;
    }

    public void description()
    {
        WriteLine($"\n{descr} --> {binary18str}");
    }
}