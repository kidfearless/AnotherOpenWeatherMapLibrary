using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using AnotherOpenWeatherMapLibrary.Models;

using Newtonsoft.Json;

namespace AnotherOpenWeatherMapLibrary
{
	public partial class OpenWeatherAPI
	{
		public string APIKey { get; set; }
		public const string APIVersion = "2.5";

		public OpenWeatherAPI() { }
		public OpenWeatherAPI(string key) => APIKey = key;

		private Task<CurrentWeather> GetCurrentWeather(string location, WeatherUnits units, LanguageCode languageCode)
		{
			var url = $"https://api.openweathermap.org/data/{APIVersion}/weather?" + 
				location + 
				$"&units={units.ToString().ToLower()}" +
				$"&lang={languageCode.ToString().ToLower()}";
			return GetResponse<CurrentWeather>(url);
		}

		public Task<CurrentWeather> GetCurrentWeatherAsync(string city, WeatherUnits units = WeatherUnits.Imperial, LanguageCode languageCode = LanguageCode.EN)
			=> GetCurrentWeather($"q={city}", units, languageCode);

		public Task<CurrentWeather> GetCurrentWeatherAsync(int cityID, WeatherUnits units = WeatherUnits.Imperial, LanguageCode languageCode = LanguageCode.EN)
			=> GetCurrentWeather($"q={cityID}", units, languageCode);

		public Task<CurrentWeather> GetCurrentWeatherAsync(double latitude, double longitude, WeatherUnits units = WeatherUnits.Imperial, LanguageCode languageCode = LanguageCode.EN)
			=> GetCurrentWeather($"lat={latitude}&lon={longitude}", units, languageCode);

		public Task<CurrentWeather> GetCurrentWeatherAsync(Coordinate coordinates, WeatherUnits units = WeatherUnits.Imperial, LanguageCode languageCode = LanguageCode.EN)
			=> GetCurrentWeather($"lat={coordinates.Latitude}&lon={coordinates.Longitude}", units, languageCode);

		#region Helper Get Methods
		private async Task<string> GetResponse(string url)
		{
			using HttpClient client = new HttpClient();
			try
			{
				return await client.GetStringAsync(url);
			}
			catch (HttpRequestException)
			{
				return null;
			}
		}
		private async Task<T> GetResponse<T>(string url)
		{
			var value = await GetResponse(url);
			return JsonConvert.DeserializeObject<T>(value);
		}
		#endregion
	}
}
