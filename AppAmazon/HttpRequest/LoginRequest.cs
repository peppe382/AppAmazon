using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AppAmazon.Classi;
using Newtonsoft.Json;

namespace AppAmazon.HttpRequest
{
    public class LoginRequest
    {
        public static async Task<Token> TryLogin(string json)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://192.168.1.18:8000/login", content);

            if (response.IsSuccessStatusCode)
            {
                string response_content = await response.Content.ReadAsStringAsync();
                Token receivedProduct = JsonConvert.DeserializeObject<Token>(response_content);
                return await Task.FromResult(receivedProduct);
            }
            else return null;
        }
    }
}
