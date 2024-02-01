namespace P2pokerInterface;

public interface IStartGameContext
{
    IReadOnlyCollection<IPlayer> Players { get; }

    int StartMoney { get; }
}