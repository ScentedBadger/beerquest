using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace beerquest
{
    public class Brewery
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "brew_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "brew_countryid")]
        public string Name { get; set; }


    }
}
