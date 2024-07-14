using System.Security.Cryptography;
using System.Text;
using Data;
using Repositorys;

namespace Models;

public class Node
{
    public Node(){}

    public Node(byte[] previous)
    {
        Id = Guid.NewGuid();
        previushash = previous;
        SetDate(DateTime.Now);
        hash = GenerateHash(Id,getDateTime());
        
    }
    public Guid Id { get; set; }
    public byte[] hash { get; set; }
    public DateTime _dateTime { get; set; }
    public byte[] previushash { get; set; }

    public async void SetNode(byte[] previus)
        => previushash = await GetPreviusContract(previus);
    
    public DateTime getDateTime()
        => _dateTime;

    public void SetDate(DateTime dateTime)
        => _dateTime = dateTime;

    private async Task<byte[]> GetPreviusContract(byte[] id)
    {
        var db = new NetworkData();
        var rp = await new NetworkRepository(db).GetNodeObject(id, CancellationToken.None) as Node;
        return rp.previushash;
    }

    public async Task<Node> getNode(byte[] previushash)
    {
        var db = new NetworkData();
        var rp = await new NetworkRepository(db).GetNodeObject(previushash, CancellationToken.None) as Node;
        return rp;
    }
    
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