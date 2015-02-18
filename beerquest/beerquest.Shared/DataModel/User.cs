using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace beerquest
{
    public class User
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "user_name")]
        public string Name { get; set; }


    }
}
