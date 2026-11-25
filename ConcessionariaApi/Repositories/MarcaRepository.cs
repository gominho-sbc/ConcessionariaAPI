using ConcessionariaApi.Contexts;
using ConcessionariaApi.Interfaces;
using ConcessionariaApi.Models;

namespace ConcessionariaApi.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly ConcessionariaContext _context;

        public MarcaRepository(ConcessionariaContext context)
        {
            _context = context;
        }

        public Marca? BuscarPorId(int id)
        {
            return _context.Marca.Find(id);
        }

        public void Cadastrar(Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();
        }

        public List<Marca> ListarMarcas()
        {
            return _context.Marca.ToList();
        }
    }
}
