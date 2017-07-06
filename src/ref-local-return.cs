using static System.Console;
using System;
using static Color.ColorChange;
using static utility.description;

public static class RefLocalReturn
{
    private static string descr = getDescriptions("Ref");
    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    private static ref int Find(int[,] matrix, Func<int, bool> predicate, out (int i, int j) index)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (predicate(matrix[i, j]))
                {
                    index.i = i; index.j = j;
                    return ref matrix[i, j];
                }
        throw new InvalidOperationException("Not found");
    }

    public static void testRef()
    {
        int[,] matrix = { { 1, 2 }, { 30, 4 }, { 55, 13 } };
        ref int v = ref Find(matrix, x => x == 55, out (int,int) index);
        (int i,int j) = index;
        WriteLine($"Before Assignment: {matrix[i,j]}");
        v = 2;
        WriteLine($"Before Assignment: {matrix[i,j]}");
    }
}