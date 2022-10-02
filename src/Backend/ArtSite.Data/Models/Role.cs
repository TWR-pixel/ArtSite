namespace ArtSite.Data.Models;

public class Role : EntityBase
{
    public string Name { get; set; }

    public Role(string name)
    {
        Name = name;
    }

    public Role()
    {

    }
}