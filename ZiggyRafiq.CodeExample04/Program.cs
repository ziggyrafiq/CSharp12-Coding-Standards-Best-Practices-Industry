using Autofac;
using Microsoft.Extensions.Logging;
using ZiggyRafiq.CodeExample04.InversionOfControl;

Console.WriteLine("Hello, from Ziggy Rafiq!");

var builder = new ContainerBuilder();

// Register dependencies
builder.RegisterType<ExampleLogger>().As<ILogger>();// Register MyLogger as ILogger
builder.RegisterType<ExampleService>(); // Register MyService

// Build the container
var container = builder.Build();

// Resolve ExampleService from the container
var exampleService = container.Resolve<ExampleService>();

// Use ExampleService
exampleService.DoSomething();