namespace Models;

public class User
{
    public User(){}
    public string Mail { get; set; }
    public string Password { get; set; }

    public User(string _mail, string _password)
    {
        this.Mail = _mail;
        this.Password = _password;
    }
}