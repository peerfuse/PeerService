namespace Data;

public class InicializaBD
{
    public InicializaBD(){}

    public void Initialize(ItemsDBContext _atlantisData)
    {
        _atlantisData.Database.EnsureCreated();
        if (_atlantisData._Items.Any())
        {
            return;
        }
        if (_atlantisData._ItemCategories.Any())
        {
            return;
        }
        _atlantisData.SaveChanges();
    }
}