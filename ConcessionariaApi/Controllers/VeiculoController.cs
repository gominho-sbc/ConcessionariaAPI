using ConcessionariaApi.Interfaces;
using ConcessionariaApi.Models;
using ConcessionariaApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{
    [Route("api/[controller]")]   // rota: api/veiculo
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        // GET api/curso
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_veiculoRepository.ListarTodos());   // 200 + lista em JSON
        }

        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {

            _veiculoRepository.Cadastrar(veiculo);
            return Created();

        }

    }
}
