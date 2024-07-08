namespace Models;

public class Peer<T>
{
        
    public Guid UserId { get; set; }
    public T chanel { get; set; }
    public T Host { get; set; }
}