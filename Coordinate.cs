
using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class Coordinate
    {
        /// <summary>
        /// City geo location, longitude
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// City geo location, latitude
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
