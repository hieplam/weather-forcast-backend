using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System;

namespace weather_forcast_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptions<OpenWeatherConfig> _openWeatherConfig;
        public WeatherController(ILogger<WeatherController> logger, IHttpClientFactory clientFactory, IOptions<OpenWeatherConfig> openWeatherConfig)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _openWeatherConfig = openWeatherConfig;
        }

        [ResponseCache(Duration = 60 * 10)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var endpointUrl = $"{_openWeatherConfig.Value.ApiEndpoint}&q={_openWeatherConfig.Value.Location}&appid={_openWeatherConfig.Value.AppId}";
            var request = new HttpRequestMessage(HttpMethod.Get, endpointUrl);
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var weatherModel = await JsonSerializer.DeserializeAsync<OpenWeatherModel>(responseStream);
                return new JsonResult(weatherModel);
            }
            else
            {
                return BadRequest();
            }            
        }
    }

    public class OpenWeatherConfig
    {
        public string ApiEndpoint { get; set; }
        public string AppId { get; set; }
        public string Location { get; set; }
    }
}