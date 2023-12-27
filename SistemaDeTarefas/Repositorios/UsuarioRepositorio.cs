using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;

        public UsuarioRepositorio(SistemaTarefasDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}