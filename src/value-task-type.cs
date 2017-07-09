using System;
using System.Threading.Tasks;
using static Color.ColorChange;
using static utility.description;
public static class ValueTaskType
{
    private static string descr = getDescriptions("ValueTask");
    public static void description()
    {
        WriteLineWithColor($"\n{descr}", ConsoleColor.Green);
    }

    public static ValueTask<int> CachedFunc()
    {
        return (cache) ? new ValueTask<int>(cacheResult) : new ValueTask<int>(LoadCache().Result);
    }
    private static bool cache = false;
    private static int cacheResult;
    private static async Task<int> LoadCache()
    {
        await Task.Delay(100);
        cacheResult = 5;
        cache = true;
        return cacheResult;
    }
}