using MerchantAPI;
using MerchantAPI.Interfaces;
using MerchantAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<MerchantDbContext>(options => options.Get)
builder.Services.AddScoped<IMerchantRepository, MerchantRepository>();
builder.Services.AddScoped<ITerminalRepository, TerminalRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

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
