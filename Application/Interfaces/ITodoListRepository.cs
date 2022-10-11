using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Interfaces;

public interface ITodoListRepository
{
    public Task<TodoList?> FindById(int id);

    public Task<EntityEntry<TodoList>> Insert(TodoList todoList);

    public Task<int> Save();
}