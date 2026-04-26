using Todoist2.Models;

namespace Todoist2.Repository.Interfaces;

public interface ITarefaRepository
{
    Task<Tarefa?> BuscarId(Guid id);
    Task<Tarefa> CriarTarefa(Tarefa novaTarefa);
    Task DeletarTarefa(Guid id);
    Task<Tarefa> AtualizarTarefa(Tarefa tarefaAtualizada);
    Task<IEnumerable<Tarefa>> BuscarPorUsuarioId(Guid id);
}