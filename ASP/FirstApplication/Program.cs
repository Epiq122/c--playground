using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to my first ASP.NET Core application!");


app.Run(async (HttpContext context) =>
{

  context.Response.Headers["MyKey"] = "my value";
  context.Response.Headers["Server"] = "My Server";
  context.Response.Headers["Content-Type"] = "text/html";

  // request headers
  string path = context.Request.Path;
  string path2 = context.Request.Method;


  await context.Response.WriteAsync("<h1>Welcome to my nightmare</h1>");

  // using the request
  await context.Response.WriteAsync("<p>My path is: " + path + "</p>");
  await context.Response.WriteAsync("<p>My method is: " + path2 + "</p>");

  // // query string
  if (context.Request.Method == "GET")
  {
    // check if the query string contains the key "id"
    if (context.Request.Query.ContainsKey("id"))
    {
      // get the value of the key "id"
      string? id = context.Request.Query["id"];
      await context.Response.WriteAsync("<p>My id is: " + id + "</p>");
    }

  }

  // http request headers ( how to read )
  if (context.Request.Headers.ContainsKey("User-Agent"))
  {
    string? userAgent = context.Request.Headers["User-Agent"];
    await context.Response.WriteAsync($"<p>{userAgent}</p>");
  }

  // read my created header ( from post man)
  if (context.Request.Headers.ContainsKey("AuthKey"))
  {
    string? authKey = context.Request.Headers["AuthKey"];
    await context.Response.WriteAsync($"<p>{authKey}</p>");
  }

});
app.Run();
