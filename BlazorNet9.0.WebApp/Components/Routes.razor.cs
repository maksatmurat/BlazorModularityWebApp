using Calabonga.Blazor.AppDefinitions;
using System.Reflection;

namespace BlazorNet9._0.WebApp.Components;

public partial class Routes
{
    public IEnumerable<Assembly> Modules => ModuleDefinitions.Instance.Assemblies; 
}
