using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Interfaces
{
    public interface IToDoRepository
    {
        Task<ToDoItem> GetByIdAsync(Guid id);
        Task<List<ToDoItem>> GetAllAsync();
        Task AddAsync(ToDoItem item);
        Task RemoveAsync(Guid id);
    }
}