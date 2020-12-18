using System;
using System.Collections.Generic;
using AppAmazon.Classi;
using AppAmazon.HttpRequest;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace AppAmazon
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void GetToken(object sender, EventArgs e)
        {
            Login log = new Login(Email.Text, Password.Text);
            string json = JsonConvert.SerializeObject(log);
            Token token = await LoginRequest.TryLogin(json);

            if (token != null)
            { 
                Ltoken.Text = token.MyToken;
                try
                {
                    await SecureStorage.SetAsync("token", token.MyToken);
                }
                catch (Exception ex)
                {
                    // Possible that device doesn't support secure storage on device.
                }
                
                //await Shell.Current.GoToAsync("Home");
            }
            else Token.Text = "Error";

        }

    }
}