using System;
using static System.Console;
using static Color.ColorChange;

namespace src
{
    class Program
    {
        static string[] quitChoices = { "quit", "q", "8" };
        static void Main(string[] args)
        {
            string option;
            printOptions();

            while ((option = ReadLine().ToLower()) != null && quit(option))
            {
                Console.Clear();
                switch (option)
                {
                    case "1":
                        NumericLiteral nl = new NumericLiteral();
                        nl.description();
                        break;
                    case "2":
                        OutVariable ov = new OutVariable();
                        ov.description();
                        break;
                    case "3":
                        TuplesEnhance te = new TuplesEnhance();
                        te.description();
                        (string name, int pen) = te.getInfoSoccerTeam();
                        (string n, string stadium, int pennant, int founded) = te.getInfoSoccerTeamInDepth();
                        var calc = TuplesEnhance.calculateAB(15, 4);
                        var calc2 = TuplesEnhance.calculateABNoSemantic(15, 4);
                        WriteLineWithColor($"Source Code Output", ConsoleColor.Red);

                        WriteLine($"{name} --> {pen}");
                        WriteLine($"{n} {pennant} {stadium} {founded}");
                        WriteLine($"Div: {calc.div}, Sum: {calc.sum}");
                        WriteLine($"Diff: {calc2.Item2}, Mult: {calc2.Item3}");
                        break;
                    default:
                        break;
                }
                printOptions();
            }
        }

        static Action printOptions = () =>
                  {
                      Option opt = new Option();
                      WriteLine($"{opt.Title} \n");
                      foreach (var o in opt.Options)
                      {
                          WriteLine($"\n{o}");
                      }
                  };
        static Func<string, bool> quit = (opt) =>
        {
            bool r = true;
            foreach (var choice in quitChoices)
                if (opt == choice)
                {
                    r = false;
                    break;
                };
            return r;
        };
    }
}
