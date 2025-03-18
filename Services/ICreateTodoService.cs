namespace ParallelTodoApp.Services;

public interface ICreateTodoService
{
    Task CreateTodoAsync(string todoName);
}
