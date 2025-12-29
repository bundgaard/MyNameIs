// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var builder = WebApplication.CreateBuilder();
builder.WebHost.UseUrls("http://localhost:8888", "https://localhost:8889");
var app = builder.Build();

app.MapGet("/api/v1/collections", () =>
{
    List<int> collections = [1, 2, 3, 4, 5, 6, 7, 8, 9];
    return Results.Ok(collections);
});
app.MapGet("/api/v1/collections/{collectionId}", (int collectionId) =>
{

    return Results.Ok(collectionId);
});


app.Run();