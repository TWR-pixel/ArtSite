namespace ArtSite.Data.Models;

public class User : EntityBase
{
    public string Name { get; set; }
    public string Nickname { get; set; }
    public string Surname { get; set; }
    public DateTime CreatedDate { get; set; }
    public Role Role { get; set; }

    public List<Art> Arts { get; set; }
    public List<Comment> Comments { get; set; }

    public User(string name, string nickname, string surname, DateTime createdDate, Role role, List<Art> arts
        , List<Comment> comments)
    {
        Name = name;
        Nickname = nickname;
        Surname = surname;
        CreatedDate = createdDate;
        Role = role;

        Arts = arts;
        Comments = comments;
    }

    public User()
    {

    }
}