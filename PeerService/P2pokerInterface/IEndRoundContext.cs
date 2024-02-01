using P2PokerStruct;

namespace P2pokerInterface;

public interface IEndRoundContext
{
    IReadOnlyCollection<PlayerActionAndName> RoundActions { get; }
}