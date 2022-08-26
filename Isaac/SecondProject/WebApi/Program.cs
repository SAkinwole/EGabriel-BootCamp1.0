using MongoDB.Driver;
using MongoDB.Entities;
using WebApi.Reposiotry;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

await DB.InitAsync("UserManagement",
    MongoClientSettings.FromConnectionString(
        "mongodb+srv://dbUser:adetunji26@cluster0.dgg1gpb.mongodb.net/?retryWrites=true&w=majority"));


builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepo, UserRepo>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
