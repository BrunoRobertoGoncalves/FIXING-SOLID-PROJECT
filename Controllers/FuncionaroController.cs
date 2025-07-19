using Microsoft.AspNetCore.Mvc;
using SOLID_FIX.Models;
using SOLID_FIX.Repositories.Interfaces;
using SOLID_FIX.Services.Interfaces;

namespace WebApiSolid.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _service;
        private readonly IFuncionarioRepository _repository;

        public FuncionarioController(IFuncionarioService service, IFuncionarioRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            _repository.Salvar(funcionario);
            return Ok("Funcionário salvo!");
        }

        [HttpGet("{id}")]
        public IActionResult Relatorio(int id)
        {
            var funcionario = _repository.ObterPorId(id);
            if (funcionario == null) return NotFound("Funcionário não encontrado.");
            var relatorio = _service.EnviarRelatorioParaRH(funcionario);
            return Ok(relatorio);
        }
    }
}
