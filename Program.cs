using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using Minimal.Api;
using System.ComponentModel.DataAnnotations;
var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();
//we create endpoints here
app.MapGet("/lena", () =>
{
    return "get chala hai";
});

app.MapPost("/dena", () =>
{
    return "post chala hai";
});
app.MapGet("/get-request", async() =>
{
    await Task.Delay(10000);
    return Results.Ok(new
    {
        Name= "Aryan"
    });
});
app.MapGet("/from-class", NewClass.func);
app.MapGet("/from-param/{age}", (int age) =>
{
    return $"current {age}";
});
app.MapGet("/get-cars/{carId:regex(^[a-z0-9]+$)}", (string carId) =>
{
    return $"{carId}";
});
app.MapGet("/fix-len/{isbn:length(3)}", (string isbn) =>
{
    return $"{isbn}";
});
app.Run();


