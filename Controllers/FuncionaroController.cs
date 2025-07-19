using Microsoft.AspNetCore.Mvc;
using SOLID_FIX.Models;
using SOLID_FIX.Services;

namespace WebApiQuebrada.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private FuncionarioService _service = new FuncionarioService();

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            _service.Salvar(funcionario);
            return Ok("Funcionário salvo!");
        }

        [HttpGet("{id}")]
        public IActionResult GerarRelatorio()
        {
            var f = new Funcionario() { Id = 1, Nome = "João" };
            return Ok(_service.GerarRelatorio(f));
        }
    }
}
