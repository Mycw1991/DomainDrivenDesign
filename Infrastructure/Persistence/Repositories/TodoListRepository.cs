using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Persistence.Repositories;

public class TodoListRepository : ITodoListRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public TodoListRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<TodoList?> FindById(int id)
    {
        return await _applicationDbContext.TodoLists.SingleOrDefaultAsync(t => t.Id == id);
    }

    public async Task<EntityEntry<TodoList>> Insert(TodoList todoList)
    {
        return await _applicationDbContext.TodoLists.AddAsync(todoList);
    }
    
    public async Task<int> Save()
    {
        return await _applicationDbContext.SaveChangesAsync();
    }
}