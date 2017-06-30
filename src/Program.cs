using System;
using static System.Console;

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
                switch (option)
                {
                    case "1":
                        NumericLiteral nl = new NumericLiteral();
                        nl.description();
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
