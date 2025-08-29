using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.UseCases;

namespace ToDoApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController: ControllerBase
    {
        private readonly CreateToDoItem _createToDoItem;

        public ToDoItemsController(CreateToDoItem createToDoItem)
        {
            _createToDoItem = createToDoItem;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateToDoDto dto)
        {
            var id = await _createToDoItem.Execute(dto.Title, dto.Description, dto.DueDate);
            return CreatedAtAction(nameof(Create), new { id }, dto);
        }

        public class CreateToDoDto
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
        }
    }
}