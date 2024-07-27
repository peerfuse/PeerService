using Data;
using Interfaces;
using Models;

namespace Progress.Data.Repository;

public class AtlantisRepository : IAtlantisData
{
    
    public CharacterDBContext _AtlantisData { get; set; }

    public AtlantisRepository(CharacterDBContext _context)
        => _AtlantisData = _context;
    
    public async Task<object?> GetObject(object _object, CancellationToken cancellationToken)
    {
        var ch = _AtlantisData._Characters.FirstOrDefault(x => x.Id == _object);
        return ch;
        
    }

    public async Task<object?> InsetObject(object _object, CancellationToken cancellationToken)
    {
        var c = _object as Character;
        await _AtlantisData._Characters.AddRangeAsync(c);
        await _AtlantisData.SaveChangesAsync(cancellationToken);
        var ch = _AtlantisData._Characters.FirstOrDefault(x => x.Id == c.Id);
        return ch;
    }

    public Task<object> UpdateObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task RemoveObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }
}