using ConcessionariaApi.Interfaces;
using ConcessionariaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcessionariaApi.Controllers
{
    [Route("api/[controller]")]   // rota: api/veiculo
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaController(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_marcaRepository.ListarMarcas());
        }

        [HttpPost]
        public IActionResult Cadastrar(Marca marca)
        {

            _marcaRepository.Cadastrar(marca);
            return Created();

        }
    }
}