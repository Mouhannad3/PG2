using WebShoppie.Domain.Services.Implementations;
using WebShoppie.Domain.Services.Interfaces;
using WebShoppie.Storage;
using WebShoppie.Storage.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
