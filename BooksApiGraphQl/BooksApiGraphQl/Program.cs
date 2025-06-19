using BooksApiGraphQl.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//GraphQl
builder.Services.AddGraphQLServer().AddQueryType<Query>();
builder.Services.AddRouting();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//GraphQl
app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });

app.Run();
