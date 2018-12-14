using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Meetup.Model
{
    public class Location
    {

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "localized_country_name")]
        public string LocalizedCountry { get; set; }

        [JsonProperty(PropertyName = "name_string")]
        public string NameString { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }

        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
    }
}
