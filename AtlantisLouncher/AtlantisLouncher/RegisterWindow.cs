using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AtlantisLouncher
{
    public partial class RegisterWindow : Gtk.Window
    {
        private static readonly HttpClient client = new HttpClient();
        private const string RadixApiBaseUrl = "https://your-radix-node-api-endpoint";
        bool onclik;

        public RegisterWindow() :base(Gtk.WindowType.Toplevel)
        {

            SetDefaultSize(200, 150);
            SetPosition(Gtk.WindowPosition.Center);
            Build();
            togglebutton1.Released += OnClikReleased;
        }

        private async void btnRetrieveAccount_Click(object sender, EventArgs e)
        {
            string privateKey = "";
            /*
            if (string.IsNullOrEmpty(privateKey))
            {
                MessageBox.Show("Por favor, insira a chave privada.");
                return;
            }
            */
            var accountInfo = await GetAccountInfo(privateKey);
            //MessageBox.Show("Informações da Conta: " + accountInfo);
        }

        static async Task<string> GetAccountInfo(string privateKey)
        {
            var content = new StringContent(JsonSerializer.Serialize(new { privateKey = privateKey }), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{RadixApiBaseUrl}/account", content);
            return await response.Content.ReadAsStringAsync();
        }

        protected async void OnClikReleased(object sender, EventArgs e)
        {
            if (!onclik)
            {
                Console.WriteLine("OnClick");
                string privateKey = "";
                var accountInfo = await GetAccountInfo(privateKey);
                onclik = true;
            }
        }
    }
}
