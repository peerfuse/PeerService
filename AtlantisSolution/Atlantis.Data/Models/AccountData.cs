namespace Models;

public class AccountData
{
    public AccountData(){}
    public string Id { get; set; }
    public string _account { get; set; }
    public string nick { get; set; }
    public string completeName { get; set; }
    public string _fone { get; set; }

    public AccountData(string id, string account, string nick, string completeName, string fone)
    {
        this.Id = id;
        this._account = account;
        this.nick = nick;
        this.completeName = completeName;
        this._fone = fone;
    }
}