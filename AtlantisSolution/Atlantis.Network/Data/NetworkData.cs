using Contracts;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class NetworkData : DbContext
{
    public NetworkData(){}
    public DbSet<Node> _nodes { get; set; }
    
    public DbSet<Contract> _Contracts { get; set; }
    
    public NetworkData(DbContextOptions<NetworkData> options) : base(options){}
}