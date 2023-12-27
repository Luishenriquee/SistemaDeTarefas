using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);

        Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id);

        Task<bool> RemoverUsuario(int id);
    }
}