using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodosTarefa();

        Task<TarefaModel> BuscarPorId(int id);

        Task<TarefaModel> AdicionarTarefa(TarefaModel tarefa);

        Task<TarefaModel> AtualizarTarefa(TarefaModel tarefa, int id);

        Task<bool> RemoverTarefa(int id);
    }
}