using System.Diagnostics;

namespace Tasks;

public class TaskExample
{
    public static async Task Test()
    {
        var watch = new Stopwatch();
        watch.Start();


        var taskList = new List<Task>();
        
        for (int i = 0; i < 100; i++)
        {
            var task = DoHeavyWork();
            taskList.Add(task);
        }

        Task.WaitAll(taskList.ToArray());
        
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
    }

    private static async Task DoHeavyWork()
    {
        Console.WriteLine("Start");

        await Task.Delay(1000);

        Console.WriteLine("Done");
    }
}