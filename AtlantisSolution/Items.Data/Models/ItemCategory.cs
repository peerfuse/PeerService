namespace Models;

public class ItemCategory
{
    public ItemCategory(){}
    public string Id { get; set; }
    public int category { get; set; }

    public ItemCategory(string Id, int category)
    {
        this.Id = Id;
        this.category = category;
    }
}