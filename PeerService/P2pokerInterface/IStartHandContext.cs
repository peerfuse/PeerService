namespace P2pokerInterface;

public interface IStartHandContext
{
    public Guid firstCard { get; set; }

    public Guid secondCard { get; set; }

    Guid PlayerName { get; }

    int HandNumber { get; }

    int MoneyLeft { get; }

    int SmallBlind { get; }
}