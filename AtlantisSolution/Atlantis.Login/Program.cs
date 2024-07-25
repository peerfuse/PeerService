using System.Security.Cryptography;
using System.Text;
using Models;
using Microsoft.AspNetCore.Mvc;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapPost("/login", async ([FromBody] User user) =>
{
    var rp = await LoginAccount(user);
    if (rp != null)
    {
        return rp;
    }
    else
    {
        return null;
    }
});

async Task<UserData> LoginAccount(User user)
{
    var rp = new AccountRepository();
    var ac = await rp.GetObject(user, CancellationToken.None) as Account;
    if(ac == null) return new UserData(Guid.NewGuid().ToString(),404, null);
    var c = GetAccount(ac, user);
    if (c == null)
    {
        return new UserData(ac.id, 401, null);
    }
    else
    {
       return c;
    }

    
}

app.MapGet("/status", () =>
{
    return $" Login Service in Running : {DateTime.Now}";
});

UserData GetAccount(Account? account, User user)
{
    var pass = ComputeSha256Hash(user.password);
    for (int i = 0; i < account.password.Length; i++)
    {
        if (pass[i] != account.password[i]) return null;
    }
    return new UserData(account.id,200,new User(account.mail, account.password));
}


string ComputeSha256Hash(string rawData)
{
    string p = "";
    for (int i = 0; i < rawData.Length; i++)
    {
        using (MD5 md5Hash = MD5.Create())
        {
            byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData[i].ToString()));
            StringBuilder builder = new StringBuilder();
            for (int x = 0; x < bytes.Length; x++)
            {
                builder.Append(bytes[x].ToString("x2"));
            }
            p += builder.ToString();
        }
    }
    return p;
}

app.Run();