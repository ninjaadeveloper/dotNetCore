var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/home", () => "This is my home page");

app.MapGet("about", () => "This is my about page");

app.Run();
