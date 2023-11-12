using Microsoft.AspNetCore.Mvc;
using lr9.Models;
using Newtonsoft.Json;

namespace lr9.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string apiKey = "7579433743fb0fad5af7251634769d9b";

        public WeatherViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string region)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={region}&appid={apiKey}");
            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode) return Content("Unable to retrieve weather data");

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<Weather>(content);
            return View(data);

        }
    }
}
