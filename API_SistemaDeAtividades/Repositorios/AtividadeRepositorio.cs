using API_SistemaDeAtividades.Data;
using API_SistemaDeAtividades.Models;
using API_SistemaDeAtividades.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_SistemaDeAtividades.Repositorios
{
    public class AtividadeRepositorio : IAtividadeRepositorio
    {
        private readonly SistemaAtividadesDBContext _dbContext;
        public AtividadeRepositorio(SistemaAtividadesDBContext sistemaAtividadesDBContext)
        {
            _dbContext = sistemaAtividadesDBContext;
        }

        public async Task<AtividadeModel> BuscarPorId(int id)
        {
            return await _dbContext.Atividades
                .Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<AtividadeModel>> BuscarTodasAtividades()
        {
            return await _dbContext.Atividades
                .Include(x => x.Usuario)
                .ToListAsync();
        }

        public async Task<AtividadeModel> Adicionar(AtividadeModel atividade)
        {
            await _dbContext.Atividades.AddAsync(atividade);
            await _dbContext.SaveChangesAsync();

            return atividade;
        }

        public async Task<AtividadeModel> Atualizar(AtividadeModel atividade, int id)
        {
            AtividadeModel atividadePorId = await BuscarPorId(id);

            if (atividadePorId == null)
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados.");

            atividadePorId.Nome = atividade.Nome;
            atividadePorId.Descricao = atividade.Descricao;
            atividadePorId.Status = atividade.Status;
            atividadePorId.UsuarioId = atividade.UsuarioId;

            _dbContext.Atividades.Update(atividadePorId);
            await _dbContext.SaveChangesAsync();

            return atividadePorId;
        }

        public async Task<bool> Apagar(int id)
        {
            AtividadeModel atividadePorId = await BuscarPorId(id);

            if (atividadePorId == null)
                throw new Exception($"Atividade para o ID: {id} não foi encontrado no banco de dados.");

            _dbContext.Atividades.Remove(atividadePorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
