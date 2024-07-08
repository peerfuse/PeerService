using System.Security.Cryptography;
using System.Text;
using Interfaces;
using Models;

namespace Contracts;

public class Contract : IContract
{
    public Contract(DateTime _dateTime)
    {
        SetDate(_dateTime);
        Id = Guid.NewGuid();
        hash = GenerateHash(Id,_dateTime);
    }

    public Guid Id { get; set; }
    public byte[] hash { get; set; }
    public Node _firstnode { get; set; }
    public DateTime _dateTime { get; set; }
    public Node _oldnode { get; set; }

    public DateTime getDateTime()
        => _dateTime;
    public void SetDate(DateTime dateTime)
        => _dateTime = dateTime;

    public void SetNode(Node _node)
        => _firstnode = _node;

    public Node getNode()
        => _firstnode;
    byte[] GenerateHash(Guid guid, DateTime dateTime)
    {
        string input = guid.ToString() + dateTime.ToString("o");
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            return hashBytes;
        }
    }
}