using Todoist2.DTOs.Tarefa;

namespace Todoist2.Services.Interfaces;

public interface ITarefaService
{
    Task<TarefaDTO> BuscarPorId(Guid id);
    Task<TarefaDTO> CriarTarefa(CriarTarefaDTO dto);
    Task<TarefaDTO> AtualizarTarefa(Guid id, AtualizarTarefaDTO dto);
    Task DeletarTarefa(Guid id);
    Task<IEnumerable<TarefaDTO>> BuscarIdUsuario(Guid id);
}