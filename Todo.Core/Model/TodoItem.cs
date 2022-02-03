using System;
using System.Collections.Generic;
using System.Text;
// TodoItem

using Microsoft.Graph;

// Todo.Core.Model
namespace Todo.Core.Model
{
    // TodoItem class
    public class TodoItem
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString() => Subject;
    }
}
