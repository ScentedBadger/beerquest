using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace beerquest
{
    public class Country
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "country_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "country_flag")]
        public string FlagLocation { get; set; }
    }
}
