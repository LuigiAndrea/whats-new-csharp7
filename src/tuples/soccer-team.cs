using System;
using System.Collections;
using System.Collections.Generic;

public class SoccerTeam
{
    public string Name { get; set; }
    public string Stadium { get; set; }
    public int Pennant { get; set; }
    public int Founded { get; set; }
    private string nickname;

    // Expression-bodied get / set accessors. Example
    public string Nickname
    {
        get => nickname;
        set => this.nickname = value ?? throw new ArgumentNullException(paramName: nameof(Nickname), message: "Nickname must not be null");
    }
    public SoccerTeam(string name) => this.Name = name;
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

public class Tournmanent : IEnumerable<SoccerTeam>
{
    private List<SoccerTeam> allTeam = new List<SoccerTeam>();
    public void AddTeam(SoccerTeam st) => allTeam.Add(st);
    public IEnumerator<SoccerTeam> GetEnumerator() => allTeam.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
