var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

// Routing 

// "/shirts"//this is uri part verb part what it means that if theres a request that comes in with the URI like / and verb is get then its going to execute this function
// minimal apis 
//app.MapGet("/shirts", () =>
//{
//    return "Reading all the shirts";
//});

//app.MapGet("/shirts/{id}", (int id) => 
//{
//    return $"Reading Shirts with ID: {id}";
//});
//app.MapPost("/shirts", () => 
//{
//    return "Creating a new shirt";
//});
//app.MapPut("/shirts/{id}", (int id) => 
//{
//    return $"Updating shirt with ID: {id}";
//});
//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting shirts with ID: {id}";
//});



app.Run();

