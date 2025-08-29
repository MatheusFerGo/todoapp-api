using ToDoApp.Core.Entities;
using ToDoApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Core.Interfaces;

namespace ToDoApp.Infrastructure.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly AppDbContext _context;

        public ToDoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ToDoItem> GetByIdAsync(Guid id) => await _context.Todos.FindAsync(id);

        public async Task<List<ToDoItem>>GetAllAsync() => await _context.Todos.ToListAsync();

        public async Task AddAsync(ToDoItem todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ToDoItem todo)
        {
            _context.Todos.Update(todo);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Guid id)
        {
            var toDoItem = await GetByIdAsync(id);
            if (toDoItem != null)
            {
                _context.Todos.Remove(toDoItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
