using Microsoft.AspNetCore.Cors.Infrastructure;
using Persistence_Layer;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string con = builder.Configuration.GetConnectionString("LocalConnectionString");
//builder.Services.AddDbContext<ProductDbContext>(p => p.UseSqlServer(con));
//builder.Services.AddScoped<ProductService>();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
