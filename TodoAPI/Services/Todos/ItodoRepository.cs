using System.Collections.Generic;
using TodoAPI.Models;

namespace TodoAPI.Services.Todos
{
    public interface ItodoRepository
    {
        public List<Todo> allTodos(int authorId);
        public Todo getTodo(int authorId, int id);
        public Todo AddTodo(int authorId, Todo todo);
        public void UpdateTodo(Todo todo);
        public void DeleteTodo(Todo todo);
    }
}
