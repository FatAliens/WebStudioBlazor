using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebStudio;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using WebStudio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
      .AddBlazorise(options =>
      {
          options.ChangeTextOnKeyPress = true;
      })
      .AddBootstrapProviders()
      .AddFontAwesomeIcons();

builder.Services.AddSingleton<LiteDbContext>();

builder.Services.AddTransient<CustomersService>();
builder.Services.AddTransient<EmployeesService>();
builder.Services.AddTransient<ProjectsService>();
builder.Services.AddTransient<ProjectTasksService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
