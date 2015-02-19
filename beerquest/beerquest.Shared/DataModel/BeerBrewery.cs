using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZUMOAPPNAME.DataModel
{
    class BeerBrewery
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "bb_beerid")]
        public string BeerId { get; set; }

        [JsonProperty(PropertyName = "bb_breweryid")]
        public string BreweryId { get; set; }
    }
}
