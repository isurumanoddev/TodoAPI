using System.Collections.Generic;
using System.Linq;
using TodoAPI.DataAccess;
using TodoAPI.Models;

namespace TodoAPI.Services.Todos
{
    public class TodoSqlServerService : ItodoRepository
    {
        private readonly TodoDBContext _dbContext = new TodoDBContext();  //Second Step

        
        public List<Todo> allTodos(int authorId)
        {
            return _dbContext.Todos.Where(Todo => Todo.AuthorId == authorId).ToList();
        }

        public Todo getTodo(int authorId,int id)
        {
            return _dbContext.Todos.FirstOrDefault(todo => todo.Id == id && todo.AuthorId == authorId);
        }

        public Todo AddTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();

            return _dbContext.Todos.Find(todo.Id);
        }

        public void UpdateTodo(Todo todo)
        {
            _dbContext.SaveChanges();
        }

        public void DeleteTodo(Todo todo)
        {
            _dbContext.Remove(todo);
            _dbContext.SaveChanges();

        }
    }
}
