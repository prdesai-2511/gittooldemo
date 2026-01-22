using MyApp.Models;
using MyApp.Services;
using Microsoft.Extensions.Configuration;

// Build configuration (reads appsettings.json if present)
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var options = config.GetSection("App").Get<AppOptions>() ?? new AppOptions { Greeting = "Hello", Name = "World" };

IGreeter greeter = new ConsoleGreeter();
greeter.Greet($"{options.Greeting}, {options.Name}!");
