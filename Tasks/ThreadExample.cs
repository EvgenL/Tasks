using System.Diagnostics;
namespace Tasks;

public class ThreadExample
{
    public static void Test()
    {
        var watch = new Stopwatch();
        watch.Start();


        for (int i = 0; i < 100; i++)
        {
            var thread = new Thread(DoHeavyWork);
            thread.Start();
        }

        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);



        void DoHeavyWork()
        {
            Console.WriteLine("Start");
            int j = 0;
            
            Thread.SpinWait(1_000_000);
            
            Console.WriteLine("Done");
        }
    }
}