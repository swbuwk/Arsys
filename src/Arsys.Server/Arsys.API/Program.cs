using Arsys.DAL.Data;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Blog System",
        Description = "A simple example ASP.NET Core Web API",

    });
    var basePath = PlatformServices.Default.Application.ApplicationBasePath;

    c.IncludeXmlComments(Path.Combine(basePath, "Api.xml"));
    c.CustomSchemaIds(x => x.FullName);
});
builder.Services.AddCors();

//DI
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
