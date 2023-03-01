using ConsomeBrasilApi.Interfaces;
using ConsomeBrasilApi.Mapping;
using ConsomeBrasilApi.Rest;
using ConsomeBrasilApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IFeriado, FeriadoService>();
builder.Services.AddSingleton<IDiscagemDiretaDistancia, DiscagemDiretaDistanciaService>();
builder.Services.AddSingleton<ICep, CepService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(FeriadoMapping));
builder.Services.AddAutoMapper(typeof(DiscagemDiretaDistanciaMapping));
builder.Services.AddAutoMapper(typeof(CepMapping));

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
