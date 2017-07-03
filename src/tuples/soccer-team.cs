public class SoccerTeam
{
    public string Name { get; set; }
    public string Stadium { get; set; }
    public int Pennant { get; set; }
    public int Founded { get; set; }

    public SoccerTeam(string name, int pennant)
    {
        Name = name;
        Pennant = pennant;
    }

    public SoccerTeam(string name, string stadium, int pennant, int founded)
    {
        Name = name;
        Pennant = pennant;
        Stadium = stadium;
        Founded = founded;
    }

    public void Deconstruct(out string name, out string stadium, out int pennant, out int founded)
    {
        name = this.Name;
        pennant = this.Pennant;
        stadium = this.Stadium;
        founded = this.Founded;
    }
}