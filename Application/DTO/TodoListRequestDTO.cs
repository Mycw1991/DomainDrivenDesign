using Domain.Entities;
using Newtonsoft.Json;

namespace Application.DTO;

public class TodoListRequestDTO
{
    [JsonProperty("title")]
    public string Title { get; set; } = null!;

    public TodoList GetTodoList()
    {
        return new TodoList() { Title = Title};
    }
}