using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace beerquest
{
    public class BeerUserData
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "buser_userid")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "buser_beerid")]
        public string BeerId { get; set; }

        [JsonProperty(PropertyName = "buser_score")]
        public int Score { get; set; }

        [JsonProperty(PropertyName = "buser_quantity")]
        public int Quantity { get; set; }
    }
}
