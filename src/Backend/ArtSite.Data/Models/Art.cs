namespace ArtSite.Data.Models;

public class Art : EntityBase
{
    public string Name { get; set; }

    /// <summary>
    /// Path to art
    /// </summary>
    public string Path { get; set; }

    public Art(string name, string path)
    {
        Name = name;
        Path = path;
    }

    public Art()
    {

    }
}