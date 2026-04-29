using Todoist2.DTOs.Usuario;

namespace Todoist2.Services.Interfaces;

public interface IUsuarioService
{
    Task<UsuarioDTO> BuscarPorId(Guid id);
    Task<UsuarioDTO> CriarUsuario(CriarUsuarioDTO dto);
    Task<UsuarioDTO> AtualizarUsuario(Guid id, AtualizarUsuarioDTO dto);
    Task DeletarUsuario(Guid id);
    Task<TokenDTO> LoginDTO(LoginDTO dto);
}