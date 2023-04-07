using MerchantAPI;
using MerchantAPI.Repository.Data;
using MerchantAPI.Repository.Implementations;
using MerchantAPI.Repository.Interfaces;
using MerchantAPI.Services.Implementations;
using MerchantAPI.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// EF Core uses this method at design time to access the DbContext
IHostBuilder CreateHostBuilder(string[] args)
    => Host.CreateDefaultBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IMerchantService, MerchantService>();
builder.Services.AddScoped<ITerminalService, TerminalService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
//builder.Services.AddScoped<IGenericRepository<T>, GenericRepository>();
builder.Services.AddScoped<IMerchantRepository, MerchantRepository>();
builder.Services.AddScoped<ITerminalRepository, TerminalRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();


builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", builder =>
      builder.AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader()
      );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.Run();
