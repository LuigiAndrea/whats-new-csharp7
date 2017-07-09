namespace utility
{
    static class Option
    {
        private static string Headline = "Choose an Option: ";
        private static string[] Options = {
            "1. Numeric literal syntax improvements",
            "2. Out variables",
            "3. Tuples Enhance",
            "4. Switch with pattern",
            "5. Ref local and return",
            "6. Local Functions",
            "7. Expression-bodied members",
            "8. Throw expression",
            "9 Generalized async return types",
            "10. Quit"
        };

        public static (string Headline, string[] Options) getOptions()
        {
            return (Headline, Options);
        }
    }
}