public static class ExtensionsTuple
{
    //Supposing that we didn't author the class SoccerTeam
    public static void Deconstruct(this SoccerTeam st, out string name, out int pennant)
    {
        name = st.Name;
        pennant = st.Pennant;
    }
}