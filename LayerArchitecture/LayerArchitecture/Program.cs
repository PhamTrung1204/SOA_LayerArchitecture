using LayerArchitecture.Business;
using LayerArchitecture.Database;
using LayerArchitecture.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Đăng ký DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Đăng ký Services & DAO
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<CustomerDAO>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<OrderDAO>();

// ✅ Thêm Controllers TRƯỚC khi `builder.Build()`
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
