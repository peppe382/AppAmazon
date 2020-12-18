using System;
using Newtonsoft.Json;

namespace AppAmazon.Classi
{
    public class Product
    {
        [JsonProperty("name")]
        private string name;

        [JsonProperty("barcode")]
        private string barcode;

        [JsonProperty("description")]
        private string description;



        public Product(string name, string barcode, string description)
        {
            this.name = name;
            this.barcode = barcode;
            this.description = description;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Product()
        {
        }

    }
}
