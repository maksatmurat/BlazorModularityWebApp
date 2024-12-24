using BlazorNet9._0.WebApp.Components;
using Calabonga.Blazor.AppDefinitions;

var builder = WebApplication.CreateBuilder(args);

builder.AddBlazorModulesDefinitions("Modules",typeof(App));
// Add services to the container.

var app = builder.Build();

app.UseDefinitions();
// Configure the HTTP request pipeline.

app.Run();
 