using System;
using System.Collections.Generic;
using AppAmazon.Classi;
using AppAmazon.HttpRequest;

using Xamarin.Forms;

namespace AppAmazon
{
    public partial class ShowProduct : ContentPage
    {
        IList<ProductResponse> products = new List<ProductResponse>();
        public IList<ProductResponse> Products { get { return products; } }

        public ShowProduct()
        {
            InitializeComponent();
            GetProduct();
        }

        private async void GetProduct()
        {
            products = await Product_All.GetProduct();
            ProductView.ItemsSource = products;
        }
    }
}
