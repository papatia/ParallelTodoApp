
namespace ParallelTodoApp.Models;
public class TodoItem(string name)
{
    public string Name { get; set; } = name;
    public List<TodoItem> SubTasks { get; set; } = [];
}
