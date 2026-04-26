using Microsoft.EntityFrameworkCore;
using Todoist2.data;
using Todoist2.Models;
using Todoist2.Repository.Interfaces;

namespace Todoist2.Repository;

public class TarefaRepository : ITarefaRepository
{
    private readonly appDbContext _context;

    public TarefaRepository(appDbContext context)
    {
        _context = context;
    }
    public async Task<Tarefa?> BuscarId(Guid id)
    {
        return await _context.tarefa.FindAsync(id);
    }

    public async Task<Tarefa> CriarTarefa(Tarefa novaTarefa)
    {
        await _context.tarefa.AddAsync(novaTarefa);
        await _context.SaveChangesAsync();
        return novaTarefa;
    }

    public async Task DeletarTarefa(Guid id)
    {
        var tarefa = await _context.tarefa.FindAsync(id);
        if (tarefa != null)
        {
            _context.tarefa.Remove(tarefa);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Tarefa> AtualizarTarefa(Tarefa tarefaAtualizada)
    {
        _context.tarefa.Update(tarefaAtualizada);
        await _context.SaveChangesAsync();
        return tarefaAtualizada;
    }
    public async Task<IEnumerable<Tarefa>> BuscarPorUsuarioId(Guid id)
    {
        return await _context.tarefa
            .Where(t => t.IdUsuario == id).ToListAsync<Tarefa>();
    }
}