using P2PokerCore;

namespace P2pokerInterface;

public interface IPostingBlindContext
{
    PlayerAction BlindAction { get; }

    int CurrentStackSize { get; }

    int CurrentPot { get; }
}