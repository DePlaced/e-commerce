using productAPI.BusinessLogic;
using productAPI.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

//Add dependency injection
builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IProductAccess, ProductAccess>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

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
