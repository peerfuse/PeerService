namespace Atlantis.Data.Data;

public class InicializaBD
{
    public InicializaBD()
    {
        
    }

    public void Initialize(AtlantisWalletData _atlantisWalletData)
    {
        _atlantisWalletData.Database.EnsureCreated();
        if (_atlantisWalletData._WalletsInfo.Any())
        {
            return;
        }
        if (_atlantisWalletData._WalletUsers.Any())
        {
            return;
        }
        _atlantisWalletData.SaveChanges();
    }
}