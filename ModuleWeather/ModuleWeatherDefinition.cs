using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleWeather;

public class ModuleWeatherDefinition : AppDefinition
{
    public override bool Exported => true;
    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, WeatherBlazorModule>();

    }
}
