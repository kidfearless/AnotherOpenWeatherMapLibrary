using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class System
    {
        [JsonProperty("type")]
        protected long Type { get; set; }

        [JsonProperty("id")]
        protected long ID { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }
    }
}
