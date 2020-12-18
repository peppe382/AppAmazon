using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AppAmazon.Classi;
using Newtonsoft.Json;

namespace AppAmazon.HttpRequest
{
    public class Product_All
    {
        public static async Task<List<ProductResponse>> GetProduct()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://192.168.1.18:8000/api/products/");

            if (response.IsSuccessStatusCode)
            {
                string response_content = await response.Content.ReadAsStringAsync();
                List<ProductResponse> receivedProduct = JsonConvert.DeserializeObject<List<ProductResponse>>(response_content);
                return await Task.FromResult(receivedProduct);
            }
            else return null;
        }
    }
}
