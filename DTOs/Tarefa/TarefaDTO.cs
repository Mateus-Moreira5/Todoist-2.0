using Todoist2.Models;

namespace Todoist2.DTOs.Tarefa;

public record TarefaDTO(
    Guid Id,
    string Titulo,
    string? Descricao,
    Prioridade Prioridade,
    Boolean concluida
    );