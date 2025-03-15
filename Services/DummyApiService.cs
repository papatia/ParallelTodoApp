

namespace ParallelTodoApp.Services;
public static class DummyApiService
{
    private static readonly Random _random = new();

    /// <summary>
    /// Simulates an external API call with a random delay (1–5 seconds).
    /// Logs the start/end to visualize parallelism in the console.
    /// </summary>
    public static async Task CreateTodoAsync(string todoName)
    {
        int delayInSeconds = _random.Next(1, 6);
        Console.WriteLine($"[API Call Start] Creating {todoName} (will take {delayInSeconds}s)");
        await Task.Delay(delayInSeconds * 1000);
        Console.WriteLine($"[API Call End]   Finished creating {todoName}");
    }
}

