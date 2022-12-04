using Aterdigital;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(c =>
{
    c.WithMethods("*");
    c.WithHeaders("*");
    c.WithOrigins("*");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
