using Calabonga.Blazor.AppDefinitions;

namespace ModuleCounter;

public class CounterBlazorModule : BlazorModule
{
    public override int OrderIndex => 1;
    public override string Title => "Counter";

    public override string Description => "Counter desc";

    public override string Route => "/counter";
}