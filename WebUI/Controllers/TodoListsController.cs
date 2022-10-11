using Application.DTO;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

[Route("[controller]")]
public class TodoListsController : ControllerBase
{
    private readonly ITodoListRepository _todoListRepository;

    public TodoListsController(ITodoListRepository todoListRepository)
    {
        _todoListRepository = todoListRepository;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        TodoList? toDoList = await _todoListRepository.FindById(id);

        return Ok(toDoList);
    }
    
    [HttpPost("")]
    public async Task<ActionResult> Post(TodoListRequestDTO todoListRequestDto)
    {
        await _todoListRepository.Insert(todoListRequestDto.GetTodoList());
        
        return Ok(_todoListRepository.Save());
    }
}
