namespace Atlantis.Wallets.Models;

public class WalletUser
{
    public WalletUser(){}
    public string Id { get; set; }
    public string userId { get; set; }
    public string walletId { get; set; }

    public WalletUser(string id, string userId, string walletId)
    {
        Id = id;
        this.userId = userId;
        this.walletId = walletId;
    }
}