using Calabonga.Blazor.AppDefinitions;

namespace ModuleWeather;

public class WeatherBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "Weather";

    public override string Description => "Weather Dec";

    public override string Route => "/weather";
}