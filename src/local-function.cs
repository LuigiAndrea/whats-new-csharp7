using static System.Console;
using System;
using static Color.ColorChange;
using static utility.description;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class LocalFunction
{
    private static string descr = getDescriptions("LocalFunc");
    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    public static void testIntersection()
    {
        int[] a = new int[5] { 1, 2, 4, 4,6 };
        int[] b = new int[4] { 4, 1, 4, 6 };

        IEnumerable<int> ResultSet;

        try
        {
            ResultSet = intersection(a, b);
            iterator(nameof(intersection));
            print(ResultSet);
        }
        catch (Exception ex)
        {
            WriteLine($"Exception {nameof(intersection)} {ex.Message}\n");
        }

        try
        {
            ResultSet = intersection2(a, b);
            iterator(nameof(intersection2) + " using local function");
            print(ResultSet);
        }
        catch (Exception ex)
        {
            WriteLine($"Exception {nameof(intersection2)} {ex.Message}\n");
        }

        try
        {
            ResultSet = intersectionTask(a, b).Result;
            iterator(nameof(intersectionTask) + " using local function in async method");
            print(ResultSet);
        }
        catch (Exception ex)
        {
            WriteLine($"Exception {nameof(intersectionTask)} {ex.Message}\n");
        }
    }

    private static void print(IEnumerable<int> rs) => rs.ToList().ForEach(x => WriteLine(x));
    private static void iterator(string name) => WriteLineWithColor($"iterator created for {name}", ConsoleColor.Blue);

    //Added constrains just to show the differences
    private static IEnumerable<int> intersection(int[] a, int[] b)
    {
        int sizeA = a.Length;
        if (sizeA != b.Length)
            throw new ArgumentOutOfRangeException("The arrays must have same size");
        else if (sizeA > 10)
            throw new ArgumentOutOfRangeException("The size of the arrays must not exceed 10 elements");

        IEnumerable<int> both = a.Intersect(b);

        foreach (var itm in both)
            yield return itm;
    }

    private static IEnumerable<int> intersection2(int[] a, int[] b)
    {
        int sizeA = a.Length;
        if (sizeA != b.Length)
            throw new ArgumentOutOfRangeException("The arrays must have same size");
        else if (sizeA > 10)
            throw new ArgumentOutOfRangeException("The size of the arrays must not exceed 10 elements");

        IEnumerable<int> both = a.Intersect(b);

        return getElements();

        IEnumerable<int> getElements()
        {
            foreach (var itm in both)
                yield return itm;
        }
    }

    private static Task<IEnumerable<int>> intersectionTask(int[] a, int[] b)
    {
        int sizeA = a.Length;
        if (sizeA != b.Length)
            throw new ArgumentOutOfRangeException("The arrays must have same size");
        else if (sizeA > 10)
            throw new ArgumentOutOfRangeException("The size of the arrays must not exceed 10 elements");

        return getElements();

        async Task<IEnumerable<int>> getElements()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            var both = a.Intersect(b);

            return both;
        }
    }
}
