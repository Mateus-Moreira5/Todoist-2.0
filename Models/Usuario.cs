namespace Todoist2.Models;

public class Usuario
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public ICollection<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();
    
    private Usuario(){ }

    public Usuario(string nome, string email, string senha)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        Senha = BCrypt.Net.BCrypt.HashPassword(senha);
    }
}