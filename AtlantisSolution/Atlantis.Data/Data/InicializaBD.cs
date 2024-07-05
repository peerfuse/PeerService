namespace Data;

public class InicializaBD
{
    public InicializaBD(){}

    public void Initialize(AtlantisData _atlantisData)
    {
        _atlantisData.Database.EnsureCreated();
        if (_atlantisData._Accounts.Any())
        {
            return;
        }
        _atlantisData.SaveChanges();
    }
}