using SOLID_FIX.Services.Interfaces;
using SOLID_FIX.Services.Implementations;
using SOLID_FIX.Repositories.Interfaces;
using SOLID_FIX.Repositories.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

var app = builder.Build();

app.MapControllers();
app.Run();
