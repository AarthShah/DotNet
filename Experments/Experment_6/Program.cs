var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var model = new HomePageModel("Welcome to Experiment 6", "This single file shows MVC idea");
var controller = new HomeController();
var html = HomeView.Render(controller.Index(model));

app.MapGet("/", () => Results.Content(html, "text/html"));

app.Run();

record HomePageModel(string Title, string Message);

class HomeController
{
    public HomePageModel Index(HomePageModel model)
    {
        return model;
    }
}

static class HomeView
{
    public static string Render(HomePageModel model)
    {
        return $"""
        <html>
        <head><title>{model.Title}</title></head>
        <body>
            <h1>{model.Title}</h1>
            <p>{model.Message}</p>
        </body>
        </html>
        """;
    }
}
