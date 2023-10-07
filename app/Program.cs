using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PeachPied.Demo.Plugins;
using PeachPied.WordPress.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddResponseCompression();
builder.Services.AddWordPress(options =>
{
    // options.SiteUrl =
    // options.HomeUrl = "http://localhost:5004";
    
    // options.PluginContainer.Add<DashboardPlugin>(); // add plugin using dependency injection
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseWordPress();

app.UseDefaultFiles();

app.Run();