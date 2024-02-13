using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MeteoFrontend;

namespace MeteoFrontend.Pages
{
    public class WeatherModel : PageModel
    {
        WeatherApiClient WeatherApi { get; set; }

        public WeatherModel(WeatherApiClient apiClient)
        {
            this.WeatherApi= apiClient;
        }

        private WeatherForecast[]? forecasts;
        
        
        public void OnGet()
        {
            forecasts = WeatherApi.GetWeatherAsync().GetAwaiter().GetResult();
            ViewData["forecasts"] = forecasts;
        }
    }
}
