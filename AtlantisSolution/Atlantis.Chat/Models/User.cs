namespace Atlantis.Chat.Models;

public class User
{
    public string mail { get; set; }
    public string password { get; set; }

    public User(string mail, string password)
    {
        this.mail = mail;
        this.password = password;
    }
}