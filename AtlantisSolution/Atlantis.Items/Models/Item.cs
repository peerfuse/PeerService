namespace Models;

public class Item
{
    public Item(){}
    public string Id { get; set; }
    public string itemHash { get; set; }
    public string displayName { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
    public int stackable { get; set; }
    public int price { get; set; }
    public string categoryId { get; set; }
    public string shoulModifiers { get; set; }
    public string ItemDateTime { get; set; }

    public Item(string Id, string itemHash, string displayName, string description, string icon, int stackable, int price, string categoryId, string shoulModifiers, string ItemDateTime)
    {
        this.Id = Id;
        this.itemHash = itemHash;
        this.displayName = displayName;
        this.description = description;
        this.icon = icon;
        this.stackable = stackable;
        this.price = price;
        this.categoryId = categoryId;
        this.shoulModifiers = shoulModifiers;
        this.ItemDateTime = ItemDateTime;
    }
}