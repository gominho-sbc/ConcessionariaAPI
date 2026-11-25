using ConcessionariaApi.Models;

namespace ConcessionariaApi.Interfaces
{
    public interface IVeiculoRepository
    {
        
        // R - Read: devolve todos os veiculo.
        List<Veiculo> ListarTodos();

        // R - Read: busca um veiculo pelo Id (ou null se não achar).
        Veiculo? BuscarPorId(int id);

        // C - Create: cadastra um veiculo novo.
        void Cadastrar(Veiculo veiculo);
    }
}

