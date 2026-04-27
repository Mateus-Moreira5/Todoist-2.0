namespace Todoist2.DTOs.Tarefa;
using Todoist2.Models;

public record CriarTarefaDTO(
    string Titulo,
    string? Descricao,
    Prioridade Prioridade, 
    Guid IdUsuario
    );