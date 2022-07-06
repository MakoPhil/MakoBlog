using MakoBlog.Server.DataProviders.Common;
using MakoBlog.Server.DataProviders.JsonDataProvider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(b => b.WithOrigins("https://localhost:5001").AllowAnyMethod().AllowAnyHeader());
});

// Setup Providers
var configuration = new ConfigurationBuilder()
	 .SetBasePath(Directory.GetCurrentDirectory())
	 .AddJsonFile($"appsettings.json")
	 .Build();

var dataProvidersSection = configuration.GetSection("DataProvider");
var dataProvidersSettings = dataProvidersSection.Get<DataProviderSettings>();
builder.Services.AddSingleton(dataProvidersSection);

if (dataProvidersSettings.DataProviderType == nameof(JsonDataProvider))
{
	var jsonDataProviderSettings = dataProvidersSection.GetSection(JsonDataProvider.ProviderSectionName).Get<JsonDataProviderSettings>();
	builder.Services.AddSingleton<IDataProvider>(new JsonDataProvider(jsonDataProviderSettings));
}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();