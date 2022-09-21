using Arsys.API.Application.Common.Mappings;
using Arsys.DAL.Data;
using Arsys.DAL.Data.Repositories.Storage;
using Arsys.DAL.Data.Repositories.Storage.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//Add MediatR and Automapper
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(config =>
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly())));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Arsys API",          
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

builder.Services.AddTransient<ISupplyRepository, SupplyRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Arsys API v1");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
