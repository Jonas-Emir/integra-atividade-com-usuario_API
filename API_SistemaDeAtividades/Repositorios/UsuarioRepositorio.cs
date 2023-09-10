using API_SistemaDeAtividades.Data;
using API_SistemaDeAtividades.Models;
using API_SistemaDeAtividades.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_SistemaDeAtividades.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaAtividadesDBContext _dbContext;
        public UsuarioRepositorio(SistemaAtividadesDBContext sistemaAtividadesDBContext)
        {
            _dbContext = sistemaAtividadesDBContext;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");

            usuarioPorId.Nome = usuario.Nome;
            usuario.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
