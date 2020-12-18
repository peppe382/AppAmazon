using System;
using Newtonsoft.Json;

namespace AppAmazon.Classi
{
    public class ProductResponse : Product
    {
        [JsonProperty("id")]
        int id;

        [JsonProperty("created_at")]
        string created_at;

        public ProductResponse()
        {
        }

        public ProductResponse(int id, string created_at)
        {
            this.id = id;
            this.created_at = created_at;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Created_at
        {
            get { return created_at; }
            set { created_at = value; }
        }
    }
}
