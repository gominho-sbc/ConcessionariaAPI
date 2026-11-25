using ConcessionariaApi.Models;

namespace ConcessionariaApi.Interfaces
{
    public interface IMarcaRepository
    {
        List<Marca> ListarMarcas();

        Marca? BuscarPorId(int id);

        void Cadastrar(Marca marca);

    }
}
