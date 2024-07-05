using System.Net;
using System.Text;
using System.Text.Json;
using Models;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Repository;

public class AccountRepository : IAccountRepository
{
    public AccountRepository(){}
    public async Task<object> SendObject(object _object, CancellationToken cancellationToken)
    {
        object? _obj = null;
        var _char = _object as User;
        string url = "http://10.0.0.155:5000/Register";

        using (HttpClientHandler handler = new HttpClientHandler())
        {
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    string json = JsonSerializer.Serialize(_char);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"ResponseBody >> {responseBody}");
                    Account obj = JsonSerializer.Deserialize<Account>(responseBody);
                    Console.WriteLine($"{obj.Id}");
                    return obj;
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