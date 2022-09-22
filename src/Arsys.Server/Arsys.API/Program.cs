using Arsys.API.Application.Common.Mappings;
using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.API.Services.CashDesk.Services.Services;
using Arsys.DAL.Data;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.DAL.Data.Repositories.CashDesk.Repositories;
using Arsys.DAL.Data.Repositories.Storage;
using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using Arsys.DAL.Data.Repositories.Сommon.Repositories;
using StackExchange.Redis;


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

builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ISupplyRepository, SupplyRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
//builder.Services.AddTransient<IShopCartRepository, ShopCartRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
//builder.Services.AddSingleton<IConnectionMultiplexer>(x =>
    //ConnectionMultiplexer.Connect(builder.Configuration.GetConnectionString("RedisConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    app.UseSwagger();   
    app.UseSwaggerUI(c => 
        { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Arsys API v.1"); });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
