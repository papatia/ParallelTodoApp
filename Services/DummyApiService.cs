

namespace ParallelTodoApp.Services;
public class DummyApiService : ICreateTodoService
{
    private static readonly Random _random = new();

    public DummyApiService()
    {
    }

    /// <summary>
    /// Simulates an external API call with a random delay (1–5 seconds).
    /// Logs the start/end to visualize parallelism in the console.
    /// </summary>
    public async Task CreateTodoAsync(string todoName)
    {
        int delayInSeconds = _random.Next(1, 6);
        Console.WriteLine($"[API Call Start] Creating {todoName} (will take {delayInSeconds}s)");
        await Task.Delay(delayInSeconds * 1000);
        Console.WriteLine($"[API Call End]   Finished creating {todoName}");
    }
}

