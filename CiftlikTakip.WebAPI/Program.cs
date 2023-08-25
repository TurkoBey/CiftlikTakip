using CiftlikTakip.Business.Extentions;
using CiftlikTakip.WebAPI.Extentions;
using CiftlikTakip.WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddApiServices();
builder.Services.AddBusinessServices();

builder.Logging.AddMyLogger(builder);

var app = builder.Build();
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCustomException();

app.Run();

