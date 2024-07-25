namespace Atlantis.Chat.Models;

public class UserData
{
    public string id { get; set; }
    public int type { get; set; }
    public User user { get; set; }

    public UserData(string _id, int _type, User _user, string id, User user)
    {
        this.id = _id;
        this.type = _type;
        this.user = _user;
    }
}