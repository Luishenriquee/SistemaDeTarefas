using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;

        public TarefaRepositorio(SistemaTarefasDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<TarefaModel> AdicionarTarefa(TarefaModel tarefa)
        {
            await _dbContext.Tarefas.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<TarefaModel> AtualizarTarefa(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaId = await BuscarPorId(id);
            if (tarefaId is null)
                throw new Exception($"Tarefa com identificador: {id}, não foi encontrado!");

            tarefaId.Name = tarefa.Name;
            tarefaId.Status = tarefa.Status;
            tarefaId.Descricao = tarefa.Descricao;
            tarefaId.Status = tarefa.Status;
            tarefaId.UsuarioId = tarefa.UsuarioId;

            _dbContext.Tarefas.Update(tarefaId);
            await _dbContext.SaveChangesAsync();

            return tarefaId;
        }

        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas
                .Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TarefaModel>> BuscarTodosTarefa()
        {
            return await _dbContext.Tarefas
                .Include(x => x.Usuario)
                .ToListAsync();
        }

        public async Task<bool> RemoverTarefa(int id)
        {
            TarefaModel tarefaId = await BuscarPorId(id);
            if (tarefaId is null)
                throw new Exception($"Tarefa com identificador: {id}, não foi encontrado!");

            _dbContext.Tarefas.Remove(tarefaId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}