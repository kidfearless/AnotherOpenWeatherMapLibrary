
using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary.Models
{
	public partial class MainWeather
    {
        /// <summary>
        /// Temperature. 
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit. 
        /// </summary>
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Temperature. This temperature parameter accounts for the human perception of weather.
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit. 
        /// </summary>
        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        /// Minimum temperature at the moment. 
        /// This is minimal currently observed temperature (within large megalopolises and urban areas).
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        /// <summary>
        /// Maximum temperature at the moment. 
        /// This is maximal currently observed temperature (within large megalopolises and urban areas).
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }

        /// <summary>
        /// Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data),
        /// hPa
        /// </summary>
        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonProperty("humidity")]
        public long Humidity { get; set; }
    }
}
