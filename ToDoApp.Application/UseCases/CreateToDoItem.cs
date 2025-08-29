using ToDoApp.Core.Entities;
using ToDoApp.Core.Interfaces;

namespace ToDoApp.Application.UseCases
{
    public class CreateToDoItem
    {
        private readonly IToDoRepository _repository;

        public CreateToDoItem(IToDoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Execute(string title, String description, DateTime dueDate)
        {
            var todoItem = new ToDoItem(title, description, dueDate);
            await _repository.AddAsync(todoItem);
            return todoItem.Id;
        }
    }
}