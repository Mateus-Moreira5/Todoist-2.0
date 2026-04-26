using Todoist2.Models;

namespace Todoist2.Repository.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> BuscarId(Guid id);
    Task<Usuario> CriarUsuario(Usuario usuario);
    Task DeletarUsuario(Guid id);
    Task<Usuario> AtualizarUsuario(Usuario usuario);
}