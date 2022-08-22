using MongoDB.Driver;
using MongoDB.Entities;
using Net6Mongo.Models.Repository;
using Net6Mongo.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// await DB.InitAsync("UserManagement",
//     MongoClientSettings.FromConnectionString(
//         "mongodb+srv://sammongo:<password>@net6withmongodb.nea1i4e.mongodb.net/?retryWrites=true&w=majority"));
//         //mongodb+srv://sammongo:<password>@net6withmongodb.nea1i4e.mongodb.net/?retryWrites=true&w=majority
        //mongodb+srv://sammongo:<password>@net6withmongodb.nea1i4e.mongodb.net/?retryWrites=true&w=majority

        // await DB.InitAsync("DatabaseName", "HostAddress", PortNumber);


//  await DB.InitAsync("UserManagement", new MongoClientSettings()
// {
//     Server = new MongoServerAddress("localhost", 27017),
//     Credential = MongoCredential.CreateCredential("UserManagement", "sammongo", "sammongo1")
// });
        
// await DB.InitAsync("DatabaseName",
//     MongoClientSettings.FromConnectionString(
//         "mongodb://{sammongo}:{sammongo1}@{hostname}:{port}/?authSource=admin"));

var settings = MongoClientSettings.FromConnectionString("mongodb+srv://sammongo:<sammongo1>@net6withmongodb.nea1i4e.mongodb.net/?retryWrites=true&w=majority");
settings.ServerApi = new ServerApi(ServerApiVersion.V1);
var client = new MongoClient(settings);
var database = client.GetDatabase("UserManagement");


builder.Services.AddScoped<IUserRepo, UserRepo>();

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
