using SOLID_FIX.Models;

namespace SOLID_FIX.Services.Interfaces
{
    public interface IFuncionarioService
    {
        double CalcularSalario(Funcionario funcionario);
        string GerarRelatorio(Funcionario funcionario);
    }
}