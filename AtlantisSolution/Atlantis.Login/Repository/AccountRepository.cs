using System.Text;
using System.Text.Json;
using Interfaces;
using Models;

namespace Repository;

public class AccountRepository : IAccountRepository
{
    public async Task<object> GetObject(object _object, CancellationToken cancellationToken)
    {
        object? _obj = null;
        var _char = _object as User;
        string url = $"http://10.0.0.155:5000/login/{_char.mail}";

        using (HttpClientHandler handler = new HttpClientHandler())
        {
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    string json = JsonSerializer.Serialize(_char);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Account obj = JsonSerializer.Deserialize<Account>(responseBody);
                    return obj!;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error No Data: {ex.Message}");
                }
            }
        }
        return _obj;
    }
}