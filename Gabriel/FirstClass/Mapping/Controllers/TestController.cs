using AutoMapper;
using Mapping.DTOs;
using Mapping.Models;
using Mapping.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mapping.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ITodoService _todoService;

    public TestController(ILogger<WeatherForecastController> logger,
        ITodoService todoService)
    {
        _logger = logger;
        _todoService = todoService;
    }

    [HttpPost]
    public IActionResult Post([FromBody]CreateTodoDto model)
    {
        if (model is null) return BadRequest("Model cannot be null");
        Todo todo = _todoService.MapTodo(model);
        return Ok(todo);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet("get_by_id")]
    public IActionResult Get([FromRoute]int Id)
    {
        return Ok();
    }
}
