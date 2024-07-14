namespace Models;

public class Account
{
    public Account(){}
    public string id { get; set; }
    public string mail { get; set; }
    public string password { get; set; }

    public Account(string id, string mail, string password)
    {
        this.id = id;
        this.mail = mail;
        this.password = password;
    }
}