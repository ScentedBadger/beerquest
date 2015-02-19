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
        public string CountryId { get; set; }

        [JsonProperty(PropertyName = "brew_website")]
        public string Website { get; set; }


    }
}
