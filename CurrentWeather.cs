
using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class CurrentWeather
    {
        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("base")]
        protected string Base { get; set; }

        [JsonProperty("main")]
        public MainWeather MainWeather { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public long DateTime { get; set; }

        [JsonProperty("sys")]
        public System System { get; set; }

        [JsonProperty("timezone")]
        public long Timezone { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cod")]
        protected long Cod { get; set; }
    }
}
