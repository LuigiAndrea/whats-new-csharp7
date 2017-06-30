using System;
using static System.Console;
using System.Linq;

namespace src
{
    class Program
    {
        static string[] quitChoices = { "quit", "q", "8" };
        static void Main(string[] args)
        {
            string option;
            options();
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
                options();
            }
        }

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

        static Action options = () =>
        {
           Option opt = new Option();
           foreach (var o in opt.Options)
           {
               WriteLine($"\n{o}");
           }
        };
    }

    class Option
    {
        public string[] Options { get; private set; }
        string[] options = {
            "1. Numeric literanl syntax improvements",
            "8. Quit"
        };

        public Option(){
            Options = options;
        }
    }
}
