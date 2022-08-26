using Mapping.DTOs;
using Mapping.Models;

namespace Mapping.Services
{
    public interface ITodoService
    {
        Todo MapTodo(CreateTodoDto model);
    }
}