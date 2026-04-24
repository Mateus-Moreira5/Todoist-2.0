using Todoist2.Models;

namespace Todoist2.Repository.Interfaces;

public interface ITarefaRepository
{
    Task<Tarefa?> BuscarId(int id);
    Task<Tarefa> CriarTarefa(Tarefa novaTarefa);
    Task DeletarTarefa(int id);
    Task<Tarefa >atualizarTarefa(Tarefa tarefaAtualizada);
    Task<IEnumerable<Tarefa>> BuscarPorUsuarioId(Guid id);
}