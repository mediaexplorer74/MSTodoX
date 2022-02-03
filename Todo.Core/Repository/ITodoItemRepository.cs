// ITodoItemRepository

using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.Model;


// Todo.Core
namespace Todo.Core
{
    // ITodoItemRepository interface
    public interface ITodoItemRepository
    {
        // Add Task
        Task AddAsync(TodoItem item);

        // List Tasks
        Task<IEnumerable<TodoItem>> ListAsync(bool listAll);
        
        // Complete Task
        Task CompleteAsync(TodoItem item);
        
        // Delete Task
        Task DeleteAsync(TodoItem item);
    }
}
