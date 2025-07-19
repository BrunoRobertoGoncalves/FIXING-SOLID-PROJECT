using SOLID_FIX.Services.Implementations;
using SOLID_FIX.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();

app.MapControllers();
app.Run();
