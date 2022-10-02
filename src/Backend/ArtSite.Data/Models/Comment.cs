namespace ArtSite.Data.Models;

public class Comment : EntityBase
{

    public string Text { get; set; }
    public User User { get; set; }

    public Comment(string text, User user)
    {
        Text = text;
        User = user;
    }

    public Comment()
    {

    }
}