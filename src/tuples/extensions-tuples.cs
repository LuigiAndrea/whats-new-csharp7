using System.Collections.Generic;
using System.Text;

public static class ExtensionsTuple
{
    //Supposing that we didn't author the class SoccerTeam
    public static void Deconstruct(this SoccerTeam st, out string name, out int pennant)
    {
        name = st.Name;
        pennant = st.Pennant;
    }

    public static void Add(this Tournmanent e, SoccerTeam s) => e.AddTeam(s);

    public static string concatTeamName(this IEnumerable<SoccerTeam> s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var team in s)
            sb.Append($"{team.Name}, ");

        sb.Remove(sb.Length - 2, 2);
        return sb.ToString();
    }
}