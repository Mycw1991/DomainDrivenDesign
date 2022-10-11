using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string? Title { get; set; }
}
