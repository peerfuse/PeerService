namespace Models;

public class Account
{
    public Account(){}
    public string Id { get; set; }
    public string mail { get; set; }
    public string password { get; set; }

    public Account(string Id, string mail, string password)
    {
        this.Id = Id;
        this.mail = mail;
        this.password = password;
    }
}