using Microsoft.EntityFrameworkCore;
using SistemaDeChamados.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona o DbContext ANTES do Build()
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MeuBancoInMemory"));

var app = builder.Build();

// Configurações do pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
