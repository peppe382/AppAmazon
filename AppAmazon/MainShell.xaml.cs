using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppAmazon
{
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Home", typeof(MainPage));
            Routing.RegisterRoute("Products", typeof(ShowProduct));
        }
    }
}
