using AutoMapper;
using Mapping.DTOs;
using Mapping.Models;

namespace Mapping.Services
{
    public class TodoService : ITodoService
    {
        private readonly IMapper _mapper;

        public TodoService(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        public Todo MapTodo(CreateTodoDto model)
        {
            Todo todo = _mapper.Map<Todo>(model);
            todo.Id = 1;
            return todo;
        }
    }
}