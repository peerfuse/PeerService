using Data;
using Atlantis.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Atlantis.Data.Repository;

public class AtlantisRepository : IAtlantisData
{
    public AtlantisData _AtlantisData { get; set; }

    public AtlantisRepository(AtlantisData atlantisData)
        => _AtlantisData = atlantisData;
    
    
    public async Task<object?> GetObject(object _object, CancellationToken cancellationToken)
    {
        object? type = null;
        var data = _object as User;
        type = await _AtlantisData._Accounts.FirstOrDefaultAsync(x => x.mail == data.mail);
        if (type is null)
        {
            await using (var context = new AtlantisData())
            {
                var _userInMysql = await _AtlantisData._Accounts.ToListAsync();
                type = _userInMysql.Find(x => x.mail == data.mail);
            }
        }
        return type;
    }

    public async Task<object> InsetObject(object _object, CancellationToken cancellationToken)
    {
        object? _obj = null;
        var _char = _object as Account;
        await _AtlantisData._Accounts.AddAsync(_char, cancellationToken);
        await _AtlantisData.SaveChangesAsync(cancellationToken);
        var _userInMemory = await _AtlantisData._Accounts.ToListAsync();
        var type = _userInMemory.Find(x => x.mail == _char.mail);
        if (type is not null)
        {
            await using (var context = new AtlantisData())
            {
                var newUserMySQL = new Account {Id = _char.Id,mail = _char.mail, password = _char.password};
                context._Accounts.Add(newUserMySQL);
                _obj = await new AtlantisRepository(_AtlantisData).GetObject(_char,cancellationToken);
            }
        }

        return _obj;
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