namespace P2pokerInterface;

public interface IEndHandContext
{
    Dictionary<string, ICollection<Guid>> ShowdownCards { get; }
}