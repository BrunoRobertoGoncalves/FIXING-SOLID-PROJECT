using Microsoft.AspNetCore.Http.HttpResults;
using SOLID_FIX.Models;
using SOLID_FIX.Repositories.Interfaces;

namespace SOLID_FIX.Repositories.Implementations
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private static readonly List<Funcionario> _bancoFake = new List<Funcionario>();
        public void Salvar(Funcionario funcionario)
        {
            _bancoFake.Add(funcionario);
        }

        public Funcionario? ObterPorId(int id)
        {
            return _bancoFake.FirstOrDefault(f => f.Id == id);
        }
    }
    
}
