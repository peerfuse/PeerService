namespace Data;

public class InicializaBD
{
    public InicializaBD(){}

    public void Initialize(InventoryDBContext _atlantisData)
    {
        _atlantisData.Database.EnsureCreated();
        if (_atlantisData._Items.Any())
        {
            return;
        }
        _atlantisData.SaveChanges();
    }
}