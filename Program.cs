// VIDEO --> https://youtu.be/MPFFLMautHw?t=2108 (47:31)

// "Program.cs is the entry point for the app that starts the server and where you configure the app services and middleware."
// https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create

// "The launchSettings.json file inside the Properties directory defines different profile settings for the local development environment. A port number is automatically assigned at project creation and saved on this file."

using BlazorApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    .AddInteractiveServerRenderMode(); // As opposed to AddInteractiveWebAssemblyRenderMode() // Which changes the way the app is rendered (SSR vs WASM)

app.Run();
