using System;
using Newtonsoft.Json;

namespace AppAmazon.Classi
{
    public class Token
    {
        [JsonProperty("username")]
        private string myToken;

        public Token(string token)
        {
            this.myToken = token;
        }

        public string MyToken
        {
            get { return myToken; }
            set { myToken = value; }
        }
    }
}
