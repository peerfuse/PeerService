using Atlantis.Data.Data;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Atlantis.Data.Repository;

public class AtlantisWalletDataRepository :IAtlantisWalletData
{
    private AtlantisWalletData _atlantisWallet { get; set; }

    public AtlantisWalletDataRepository(AtlantisWalletData data)
        => _atlantisWallet = data;


    public async Task<object?> GetObjectWalletInfo(object _object, CancellationToken cancellationToken)
    {
        object? type = null;
        var data = _object as WalletInfo;
        type = await _atlantisWallet._WalletsInfo.FirstOrDefaultAsync(x => x.walletId == data.walletId);
        if (type is null)
        {
            await using (var context = new AtlantisWalletData())
            {
                var _userInMysql = await _atlantisWallet._WalletsInfo.ToListAsync();
                type = _userInMysql.Find(x => x.walletId == data.walletId);
            }
        }
        return type;
    }

    public async Task<object> InsetObjectWalletInfo(object _object, CancellationToken cancellationToken)
    {
        object? _obj = null;
        var _char = _object as WalletInfo;
        await _atlantisWallet._WalletsInfo.AddAsync(_char, cancellationToken);
        await _atlantisWallet.SaveChangesAsync(cancellationToken);
        var _userInMemory = await _atlantisWallet._WalletsInfo.ToListAsync();
        var type = _userInMemory.Find(x => x.walletId == _char.walletId);
        if (type is not null)
        {
            await using (var context = new AtlantisWalletData())
            {
                var newUserMySQL = new WalletInfo {Id = _char.Id,walletId = _char.walletId, item = _char.item};
                context._WalletsInfo.Add(newUserMySQL);
                _obj = await new AtlantisWalletDataRepository(_atlantisWallet).GetObjectWalletInfo(_char,cancellationToken);
            }
        }

        return _obj;
    }

    public async Task<object?> GetObjectWalletUser(object _object, CancellationToken cancellationToken)
    {
        object? type = null;
        var data = _object as WalletUser;
        type = await _atlantisWallet._WalletUsers.FirstOrDefaultAsync(x => x.userId == data.userId);
        if (type is null)
        {
            await using (var context = new AtlantisWalletData())
            {
                var _userInMysql = await _atlantisWallet._WalletUsers.ToListAsync();
                type = _userInMysql.Find(x => x.userId == data.userId);
            }
        }
        return type;
    }

    public async Task<object> InsetObjectWalletUser(object _object, CancellationToken cancellationToken)
    {
        object? _obj = null;
        var _char = _object as WalletUser;
        await _atlantisWallet._WalletUsers.AddAsync(_char, cancellationToken);
        await _atlantisWallet.SaveChangesAsync(cancellationToken);
        var _userInMemory = await _atlantisWallet._WalletUsers.ToListAsync();
        var type = _userInMemory.Find(x => x.walletId == _char.walletId);
        if (type is not null)
        {
            await using (var context = new AtlantisWalletData())
            {
                var newUserMySQL = new WalletUser {Id = _char.Id,userId = _char.userId, walletId  = _char.walletId};
                context._WalletUsers.Add(newUserMySQL);
                _obj = await new AtlantisWalletDataRepository(_atlantisWallet).GetObjectWalletInfo(_char,cancellationToken);
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