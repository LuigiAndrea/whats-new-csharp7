using System.Collections.Generic;

namespace utility
{
    public static class description
    {
        private static Dictionary<string, string> descriptions = new Dictionary<string, string>()
        {
            ["NumericLiteral"] = "From C#7 is possible to Use the 0b prefix for binary literals and underscores to improve readability",
            ["OutVariable"] = "From C# 7, you can declare variables on the fly when calling methods with out parameters",
            ["SwitchPattern"] = "From C# 7, you can switch on an object's type, the order of the case clauses is relevant except for the default clause",
            ["Tuples"] = "Improved the efficiency and language support for tuples (enables semantic names) Look the source code for examples on \n1. Syntax, tuple and assignment \n2. return multiple values \n3. Deconstruct and Extensions",
        };

        public static string getDescriptions(string key)
        {
            return descriptions[key];
        }
    }
}