using System;
using Microsoft.Net.Http.Headers;
using System.Net.Http; 
using AppAmazon.Classi;
using System.Text;
using System.Threading.Tasks;
using AppAmazon.HttpRequest;
using Newtonsoft.Json;

namespace AppAmazon.HttpRequest
{
    public static class ProductRequest
    {

        public static async Task<ProductResponse> InsertProduct(string json)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://192.168.1.18:8000/api/products/", content);

            if (response.IsSuccessStatusCode)
            {
                string response_content = await response.Content.ReadAsStringAsync();
                ProductResponse receivedProduct = JsonConvert.DeserializeObject<ProductResponse>(response_content);
                return await Task.FromResult(receivedProduct);
            }
            else return null;
        }
    }
}
