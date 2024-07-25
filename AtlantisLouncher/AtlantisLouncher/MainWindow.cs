using System;
using Gtk;
using AtlantisLouncher;
using System.Net.Http;
using AtlantisLouncher.Core;
using System.Text.Json;
using System.Text;
using AtlantisLouncher.Wins;

public partial class MainWindow : Window
{
    bool onclik, onregister;
    RegisterWindow registerWindow;
    HttpClient _httpClient;
    public MainWindow() : base(WindowType.Toplevel)
    {
        Build();
        button2.Clicked += OnClik;
        button2.Released += OnClikReleased;
        button3.Clicked += OnRegister;
        button3.Released += OnRegisterReleased;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnClik(object sender, EventArgs e)
    {
        if (!onclik)
        {
            Send();
            Console.WriteLine(nameof(OnClik));
            onclik = true;
        }
    }

    private async void Send()
    {
        string mail = entry2.Text;
        string pass = entry3.Text;
        var user = new User(mail, pass);
        string url = "https://localhost:7054/Login";

        using (HttpClientHandler handler = new HttpClientHandler())
        {
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    string json = JsonSerializer.Serialize(user);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"ResponseBody >> {responseBody}");
                    UserData obj = JsonSerializer.Deserialize<UserData>(responseBody);
                    Console.WriteLine($"{obj.uid}");
                    if (obj != null)
                    {
                        MessageWind w = new MessageWind();
                        w.Show();
                        w.Message("Login Realizado Com Sucesso !");
                        label3.Text = obj.uid;
                        label4.Text = DateTime.Now.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error No Data: {ex.Message}");
                }
            }
        }
    }

    protected void OnRegister(object sender, EventArgs e)
    {
        if (!onregister)
        {
            Console.WriteLine(nameof(OnRegister));
            registerWindow = new RegisterWindow();
            registerWindow.Show();
            onregister = true;
        }
    }

    protected void OnClikReleased(object sender, EventArgs e)
    {
        onclik = false;
    }

    protected void OnRegisterReleased(object sender, EventArgs e)
    {
        onregister = false;
    }
}
