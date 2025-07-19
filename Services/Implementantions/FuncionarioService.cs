using SOLID_FIX.Models;
using SOLID_FIX.Services.Interfaces;

namespace SOLID_FIX.Services.Implementantions
{
    public class FuncionarioService
    {
       public double CalcularSalario(Funcionario funcionario)
       {
            return funcionario.SalarioBase;
       }
       public string GerarRelatorio(Funcionario funcionario)
       {
            return $"Funcionario: {funcionario.Nome}, Salário: {funcionario.SalarioBase}";
       }
    }
}
     