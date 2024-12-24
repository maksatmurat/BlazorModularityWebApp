using BlazorNet9._0.WebApp.Components;
using Calabonga.Blazor.AppDefinitions;
using System.Collections.Generic;
using System.Reflection;

namespace BlazorNet9._0.WebApp;

public class CommonDefinition:AppDefinition
{
    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

    }
    public override void ConfigureApplication(WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        
        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddAdditionalAssemblies(ModuleDefinitions.Instance.Assemblies.ToArray());

    }
}

