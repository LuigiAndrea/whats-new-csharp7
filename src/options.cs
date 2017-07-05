class Option
{
    public string[] Options { get; private set; }
    public string Title { get; private set; }
    private string[] options = {
            "1. Numeric literal syntax improvements",
            "2. Out variables",
            "3. Tuples Enhance",
            "4. Switch with pattern",
            "8. Quit"
        };

    public Option()
    {
        Title = "Choose an Option: ";
        Options = options;
    }
}





