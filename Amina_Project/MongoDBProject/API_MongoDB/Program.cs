using API_MongoDB.Respository;
using Microsoft.OpenApi.Models;
using MongoDB.Driver;
using MongoDB.Entities;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//await DB.InitAsync("UserManagement",
    //MongoClientSettings.FromConnectionString("mongodb+srv://Pearl:LpcGcW5azR4mQUZ2@cluster0.zy4uivh.mongodb.net/?retryWrites=true&w=majority"));
// Add services to the container.


builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    a =>
    {
        a.SwaggerDoc("v1",
            new OpenApiInfo
            {
                Title = "User Management API",
                Version = "v1",
                Description = "This is an API that performs CRUD operations for User Management.",
                Contact = new OpenApiContact
                {
                    Name = "Amina Bakare",
                    Email = "bakareaminata@gmail.com"
                }
            });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        a.IncludeXmlComments(xmlPath);
        a.EnableAnnotations();
    });

    


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(a =>
    a.SwaggerEndpoint("/swagger/v1/swagger.json",
    "Swagger Demo Documentation v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
