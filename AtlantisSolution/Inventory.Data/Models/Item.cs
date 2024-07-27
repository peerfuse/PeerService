namespace Models;

public class Item
{
    public Item(){}
    public string Id { get; set; }
    public string itemHash { get; set; }
    public int quantity { get; set; }
    public int position { get; set; }

    public Item(string Id, string itemHash, int quantity, int position)
    {
        this.Id = Id;
        this.itemHash = itemHash;
        this.quantity = quantity;
        this.position = position;
    }
}