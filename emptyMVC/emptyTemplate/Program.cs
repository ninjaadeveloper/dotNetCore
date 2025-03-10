var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=Index}"
    );

app.Run();
