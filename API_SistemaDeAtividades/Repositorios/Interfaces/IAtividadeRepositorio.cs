using API_SistemaDeAtividades.Models;

namespace API_SistemaDeAtividades.Repositorios.Interfaces
{
    public interface IAtividadeRepositorio
    {
        Task<List<AtividadeModel>> BuscarTodasAtividades();
        Task<AtividadeModel> BuscarPorId(int id);
        Task<AtividadeModel> Adicionar(AtividadeModel atividade);
        Task<AtividadeModel> Atualizar(AtividadeModel atividade, int id);
        Task<bool> Apagar(int id);
    }
}
