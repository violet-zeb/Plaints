using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Models
{
    public class Ingredients
    {
        internal string name;
        internal string unit;
        internal string amount;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

    }
}
