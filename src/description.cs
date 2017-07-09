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
            ["Ref"] = "Ref locals and ref returns enable algorithms that are more efficient by avoiding copying values, or performing dereferencing operations multiple times.",
            ["LocalFunc"] = "From C# 7, you can define a method inside another method. There are two very common use cases for local functions: public iterator methods and public async methods. Both types of methods generate code that reports errors later than programmers might expect.",
            ["Expression"] = "From C# 7 there are more members allowed to be implemented as expressions. Constructors, finalizers, and get and set accessors on properties and indexers. Look at Soccer-Team or Local-function files for some examples",
            ["Throw"] = "From C# 7 is allowed to use throw expression in conditional expressions, null coalescing expressions, lambda expressions and expression-bodied functions. Look at Soccer-Team or Local-function files for some examples",
            ["ValueTask"] = "From C# 7 to improve performance of code in cases where an async method returns a cached result, or completes synchronously has been added ValueTask type."
        };

        public static string getDescriptions(string key)
        {
            return descriptions[key];
        }
    }
}