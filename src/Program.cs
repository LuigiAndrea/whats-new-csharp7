using System;
using static System.Console;
using static Color.ColorChange;
using System.Linq;
using static utility.Option;
using sp = SwitchPattern;
using te = TuplesEnhance;

namespace src
{
    class Program
    {
        static string[] quitChoices = { "quit", "q", "8" };
        static void Main(string[] args)
        {
            string option;
            printOptions();

            while ((option = ReadLine().ToLower()) != null && !quit(option))
            {
                Console.Clear();
                switch (option)
                {
                    case "1":
                        NumericLiteral.description();
                        break;
                    case "2":
                        OutVariable.description();
                        sourceCodeOutput();
                        OutVariable.discardParameters();
                        break;
                    case "3":
                        te.description();
                        (string name, int pen) = te.getInfoSoccerTeam();
                        (string n, string stadium, int pennant, int founded) = te.getInfoSoccerTeamInDepth();
                        var calc = te.calculateAB(15, 4);
                        var calc2 = te.calculateABNoSemantic(15, 4);
                        sourceCodeOutput();

                        WriteLine($"{name} --> {pen}");
                        WriteLine($"{n} {pennant} {stadium} {founded}");
                        WriteLine($"Div: {calc.div}, Sum: {calc.sum}");
                        WriteLine($"Diff: {calc2.Item2}, Mult: {calc2.Item3}");
                        break;
                    case "4":
                        sp.description();
                        sourceCodeOutput();
                        sp.printTypeAndValue(new myType("luigi"));
                        sp.printTypeAndValue(2);
                        sp.printTypeAndValue("dsadsadas");
                        break;
                    case "5":
                    RefLocalReturn.description();
                    sourceCodeOutput();
                    RefLocalReturn.testRef();
                    break;
                    default:
                        break;
                }
                printOptions();
            }
            Console.Clear();
        }

        static Action sourceCodeOutput = () => WriteLineWithColor($"Source Code Output", ConsoleColor.Red);
        static Action printOptions = () =>
                  {
                      var (Headline, Options) = getOptions();
                      WriteLine($"{Headline} \n");
                      foreach (var o in Options)
                      {
                          WriteLine($"\n{o}");
                      }
                  };
        static Func<string, bool> quit = (opt) => quitChoices.Contains(opt);
    }
}
