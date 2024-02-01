using P2PokerEnums;
using P2PokerStruct;

namespace P2pokerInterface;

public interface IStartRoundContext
{
    IReadOnlyCollection<Guid> CommunityCards { get; }

    int CurrentPot { get; }

    int MoneyLeft { get; }

    GameRoundType RoundType { get; }

    Pot CurrentMainPot { get; }

    IReadOnlyCollection<Pot> CurrentSidePots { get; }
}