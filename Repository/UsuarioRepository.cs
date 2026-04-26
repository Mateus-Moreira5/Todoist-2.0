    using Todoist2.data;
    using Todoist2.Models;
    using Todoist2.Repository.Interfaces;

    namespace Todoist2.Repository;

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly appDbContext _context;

        public UsuarioRepository(appDbContext context)
        {
            _context = context;
        }
        
        public async Task<Usuario?> BuscarId(Guid id)
        {
            return await _context.usuario.FindAsync(id);
        }

        public async Task<Usuario> CriarUsuario(Usuario usuario)
        { 
            await _context.usuario.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task DeletarUsuario(Guid id)
        {
            var usuario = await _context.usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.usuario.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Usuario> AtualizarUsuario(Usuario usuario)
        {
            _context.usuario.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
    }