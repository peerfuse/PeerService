namespace P2pokerInterface;

public interface ICard
{
    Guid UUID { get; set; }
    int value { get; set; }
}