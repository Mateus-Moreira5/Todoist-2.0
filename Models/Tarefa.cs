namespace Todoist2.Models;

public class Tarefa
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string? Descricao { get; private set; }
    public Prioridade Prioridade { get; private set; }
    public bool Concluida { get; private set; }
    public Guid IdUsuario { get; private set; }
    
    public Usuario Usuario { get; private set; }
    
    private Tarefa() {}
    
    public Tarefa(string titulo, string? descricao, Prioridade prioridade, Guid idUsuario)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Descricao = descricao;
        Prioridade = prioridade;
        Concluida = false;
        IdUsuario = idUsuario;
    }
}