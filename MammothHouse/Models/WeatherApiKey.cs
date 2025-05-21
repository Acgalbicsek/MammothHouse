namespace MammothHouse.Models
{
    public class WeatherApiKey(HttpClient httpClient, IConfiguration config)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly string _apiKey = config["ApiKeys:Weather"];

        public async Task<string> GetWeatherAsync(string city)
        {
            var url = $"https://api.weatherapi.com/v1/current.json?key={_apiKey}&q={city}";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
