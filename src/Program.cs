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
                        ov.convertStringToIntNOW();
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
