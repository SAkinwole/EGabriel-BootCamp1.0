
using AutoMapper;
using Mapping.DTOs;
using Mapping.Models;

namespace Mapping.Profiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            //Source ==> Target
            CreateMap<CreateTodoDto, Todo>()
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.TodoName));

            CreateMap<Todo, ReadTodoDto>().ReverseMap();
        }
    }
}