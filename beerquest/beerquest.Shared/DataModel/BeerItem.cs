using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace beerquest
{
    public class BeerItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "beer_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "beer_abv")]
        public string ABV { get; set; }

        [JsonProperty(PropertyName = "beer_style")]
        public string BeerStyle { get; set; }

    }

}


