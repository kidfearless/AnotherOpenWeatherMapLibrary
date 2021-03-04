
using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class Wind
    {
        /// <summary>
        /// Wind speed. 
        /// Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonProperty("deg")]
        public long Degrees { get; set; }
    }
}
