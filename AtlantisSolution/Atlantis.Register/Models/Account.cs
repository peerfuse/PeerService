namespace Models;

public class Account
{
    public Account(){}
    public string id { get; set; }
    public string mail { get; set; }
    public string password { get; set; }

    public Account(string _id, string _mail, string _password)
    {
        this.id = _id;
        this.mail = _mail;
        this.password = _password;
    }
}