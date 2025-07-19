using SOLID_FIX.Models;
using SOLID_FIX.Services.Interfaces;

namespace SOLID_FIX.Services.Implementations
{
    public class FuncionarioService : IFuncionarioService
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            return funcionario.SalarioBase;
        }
        public string EnviarRelatorioParaRH(Funcionario funcionario)
        {
            return $"Funcionario: {funcionario.Nome}, Sálario: {funcionario.SalarioBase}";
        }
    }
}
