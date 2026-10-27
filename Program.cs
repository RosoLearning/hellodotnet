var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    name = "hellodotnet",
    description = "basic dotnet app via backstage",
    status = "ok"
}));

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

app.Run();
