using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppAmazon.Classi;
using AppAmazon.HttpRequest;
using Xamarin.Forms;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AppAmazon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetToken()
        {
            try
            {
                var token = await SecureStorage.GetAsync("oauth_token");
                labelToken.Text = token;
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
            
        }

        private async void SendProduct(object sender, EventArgs e)
        {
            if (p_name.Text != null && p_barcode != null)
            {
                Product product = new Product(p_name.Text, p_barcode.Text, p_description.Text);
                string json = JsonConvert.SerializeObject(product);
                ProductResponse product_received = await ProductRequest.InsertProduct(json);



                if (product_received != null)
                {
                    pr_id.Text = Convert.ToString(product_received.Id);
                    pr_name.Text = product_received.Name;
                    pr_barcode.Text = product_received.Barcode;
                    pr_description.Text = product_received.Description;
                    pr_created.Text = Convert.ToString(product_received.Created_at);
                }
                else pr_id.Text = "Error";
            }
        }

        private void ShowProductButton(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Products");
        }
    }
}


