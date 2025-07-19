using SOLID_FIX.Models;

namespace SOLID_FIX.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Salvar(Funcionario funcionario);
        Funcionario? ObterPorId(int id);
    }
}
