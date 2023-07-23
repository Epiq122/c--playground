var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to my first ASP.NET Core application!");


app.Run(async (HttpContext context) =>
{

  context.Response.Headers["MyKey"] = "my value";
  context.Response.Headers["Server"] = "My Server";
  context.Response.Headers["Content-Type"] = "text/html";


  await context.Response.WriteAsync("<h1>Welcome</h1");
});
app.Run();
