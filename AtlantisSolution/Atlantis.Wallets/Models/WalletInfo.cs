namespace Atlantis.Wallets.Models;

public class WalletInfo
{
    public WalletInfo(){}
    public string Id { get; set; }
    public string walletId { get; set; }
    public string item { get; set; }

    public WalletInfo(string id, string walletId, string item)
    {
        Id = id;
        this.walletId = walletId;
        this.item = item;
    }
}