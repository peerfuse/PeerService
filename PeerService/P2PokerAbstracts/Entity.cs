namespace P2PokerAbstracts;

public abstract class Entity
{
    public Guid Id { get; set; }

    public Entity() => Id = Guid.NewGuid();
}