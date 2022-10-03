using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;
using TodoAPI.Services.Models;
using TodoAPI.Services.Todos;

namespace TodoAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ItodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ItodoRepository repository,IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<TodoDTO>> getTodos(int authorId)
        {
            var myTodos = _todoService.allTodos(authorId);
            var mappedTodo = _mapper.Map<ICollection<TodoDTO>>(myTodos);



            return Ok(mappedTodo);
        }
        [HttpGet("{id}",Name = "getTodo")]
        public IActionResult getTodo(int authorId,int id)
        {
            var myTodos = _todoService.getTodo(authorId,id);
            if (myTodos is null)
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDTO>(myTodos);

            return Ok(mappedTodo);
        }

        [HttpPost]
        public ActionResult<TodoDTO> CreateTodo(int authorId,CreateTodoDTO todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId,todoEntity);

            var todoForReturn = _mapper.Map<TodoDTO>(newTodo);
            return CreatedAtRoute("getTodo", new { authorId = authorId, id = todoForReturn.Id },todoForReturn);
        }

        [HttpPut("{todoId}")]
        public ActionResult UpdateTodo(int authorId, int todoId, UpdateTodoDTO todo)
        {
            var updatingTodo = _todoService.getTodo(authorId, todoId);

            if (updatingTodo is null)
            {
                return NotFound();
            }
            
            _mapper.Map(todo, updatingTodo);
            _todoService.UpdateTodo(updatingTodo);

            return NoContent();
        }

        [HttpDelete("{todoId}")]
        public ActionResult DeleteTodo(int authorId, int todoId)
        {
            var DeleteTodo = _todoService.getTodo(authorId, todoId);

            if (DeleteTodo is null)
            {
                return NotFound();
            }
            _todoService.DeleteTodo(DeleteTodo);

            return NoContent();
        }



    }
}
