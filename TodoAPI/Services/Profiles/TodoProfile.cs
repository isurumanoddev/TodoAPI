using AutoMapper;
using TodoAPI.Models;
using TodoAPI.Services.Models;

namespace TodoAPI.Services.Profiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, TodoDTO>();
            CreateMap<CreateTodoDTO, Todo>();
            CreateMap<UpdateTodoDTO, Todo>();
        }
    }
}
