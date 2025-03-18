using ParallelTodoApp.Models;
using ParallelTodoApp.Services;

namespace ParallelTodoApp;

public static class Program
{

    public static async Task Main()
    {
        var task1 = new TodoItem("Task1");

        var task11 = new TodoItem("Task11");
        task11.SubTasks.Add(new TodoItem("Task111"));
        task11.SubTasks.Add(new TodoItem("Task112"));
        task11.SubTasks.Add(new TodoItem("Task113"));

        var task12 = new TodoItem("Task12");
        task12.SubTasks.Add(new TodoItem("Task121"));
        task12.SubTasks.Add(new TodoItem("Task122"));
        task12.SubTasks.Add(new TodoItem("Task123"));

        task1.SubTasks.Add(task11);
        task1.SubTasks.Add(task12);
        ICreateTodoService service = new DummyApiService();
        // Start the creation process
        Console.WriteLine("=== Starting Todo Creation ===");
        await CreateTodoWithSubTasks(task1, service);

        Console.WriteLine("All tasks submitted. Press any key to exit.");
        Console.ReadKey();
    }

    /// <summary>
    /// Creates the given todo item (awaits it),
    /// then for each subtask in order:
    ///   1) Create the subtask (await)
    ///   2) In parallel, create the sub-sub tasks (and so on, recursively),
    ///      but don't wait for them before creating the next sibling subtask.
    /// </summary>
    public static async Task CreateTodoWithSubTasks(TodoItem todo, ICreateTodoService service)
    {
        // TODO
    }
}
