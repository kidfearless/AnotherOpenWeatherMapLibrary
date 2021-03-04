
using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class Clouds
    {
        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonProperty("all")]
        public int All { get; set; }

        public static implicit operator int(Clouds clouds) => clouds.All; 
    }
}
