using CSharpProjeto.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ProdutoRepo>();

var app = builder.Build();
app.MapControllers();
app.Run();
