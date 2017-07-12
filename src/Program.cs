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
        static string[] quitChoices = { "quit", "q", "10" };
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
                        te.buildTournament();
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
                    case "6":
                        LocalFunction.description();
                        sourceCodeOutput();
                        LocalFunction.testIntersection();
                        break;
                    case "7":
                        ExpressionBodied.description();
                        break;
                    case "8":
                        Throw.description();
                        break;
                    case "9":
                        ValueTaskType.description();
                        sourceCodeOutput();
                        var a = ValueTaskType.CachedFunc();
                        WriteLine(a);
                        break;
                    default:
                        break;
                }
                printOptions();
            }
            Console.Clear();
        }

        private static void sourceCodeOutput() => WriteLineWithColor($"Source Code Output", ConsoleColor.Red);
        private static bool quit(string opt) => quitChoices.Contains(opt);
        private static void printOptions()
        {
            var (Headline, Options) = getOptions();
            WriteLine($"{Headline} \n");
            foreach (var o in Options)
            {
                WriteLine($"\n{o}");
            }
        }
    }
}
