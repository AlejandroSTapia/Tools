using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    internal class RandomApiModel
    {

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

    }
}
