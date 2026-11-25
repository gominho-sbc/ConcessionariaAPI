using ConcessionariaApi.Contexts;
using ConcessionariaApi.Interfaces;
using ConcessionariaApi.Models;

namespace ConcessionariaApi.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ConcessionariaContext _context;

        public VeiculoRepository(ConcessionariaContext context)
        {
            _context = context;
        }

        public Veiculo? BuscarPorId(int id)
        {
            return _context.Veiculo.Find(id);
        }

        public void Cadastrar(Veiculo veiculo)
        {
            _context.Veiculo.Add(veiculo);   // coloca na fila (marca para inserir)
            _context.SaveChanges();
        }

        public List<Veiculo> ListarTodos()
        {
            return _context.Veiculo.ToList();
        }
    }
}
