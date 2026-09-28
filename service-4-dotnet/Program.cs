using Microsoft.EntityFrameworkCore;
using service_4_dotnet.Data;
using service_4_dotnet.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("PersonList"));

// RabbitMQ Subscriber ကို Background Task အနေဖြင့် ထည့်သွင်းခြင်း
builder.Services.AddHostedService<RabbitMqSubscriberService>();

// 🌟 ယခုအသစ်ထည့်လိုက်သော Prefetch(1) Work Queue Worker
builder.Services.AddHostedService<RabbitMqWorkerService>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();