using System.Diagnostics;
using System.Threading.Tasks;

class UpCounter {

    public void CountUp(int count)
    {
        Console.WriteLine("Counting up Started:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"i : {i}");
             // Simulating some work with a delay
        }
        Console.WriteLine("Counting up Finished");
    }

}

class DownCounter {

    public void CountDown(int count)
    {
        Console.WriteLine("Counting Down Started:");
        for (int j = count; j >= 1; j--)
        {
            Console.Write($"j : {j + 1}");
        }
        Console.WriteLine("Counting Down Finished");
    }
}


class Program
{
    static void Main()
    {
    
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        WithTask();
        stopwatch.Stop();
        long TimeTakenByTask = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Time taken by Task: {TimeTakenByTask} ms");
        Console.WriteLine("--------------------------------------------------");
    //    stopwatch.Restart();
    ////        WithThreads();
    //    stopwatch.Stop();
    //    long TimeTakenByThread = stopwatch.ElapsedMilliseconds;
    //    Console.WriteLine($"Time taken by Thread: {TimeTakenByThread} ms");

        //long trillion = 1000000000000;
        //long differ = 0;
        //stopwatch.Start();
        //while (differ < trillion)
        //{
        //    differ++;
        //}
        //stopwatch.Stop();
        //long TimeTakenByWhileLoop = stopwatch.ElapsedMilliseconds;
        //Console.WriteLine($"Time taken by While Loop: {TimeTakenByWhileLoop} ms");

        Console.WriteLine("End Of Main Thread");
    }

    static void WithTask()
    {
        // Creating Object For Both Classes

        UpCounter upCounter = new UpCounter();
        DownCounter downCounter = new DownCounter();
       

        // create and start the tasks

        Task Task1 = Task.Factory.StartNew(() =>
        {
            upCounter.CountUp(100);
      
        });

        Task continouetaskfirst = Task1.ContinueWith((antecedent) =>
        {
            Console.WriteLine("Task one result");
            
        });
        Task Task2 = Task.Factory.StartNew(() => {

            downCounter.CountDown(100);
            
        });
        Task continouetasktwo = Task2.ContinueWith((antecedent) =>
        {
            Console.WriteLine("task 2 result");
        });

        //Task.WaitAll(Task1, Task2);
       // Console.WriteLine($"Task {completed} completed first.");
        
        Console.WriteLine("--------------------------------------------------");

    }

    //static void WithThreads()
    //{
    //    // Creating Object For Both Classes

    //    UpCounter upCounter = new UpCounter();
    //    DownCounter downCounter = new DownCounter();
    //    CountdownEvent countdownEvent = new CountdownEvent(2);

    //    Thread thread1 = new Thread(() =>
    //    {
    //        upCounter.CountUp(100);
    //        countdownEvent.Signal();
    //    });

    //    Thread thread2 = new Thread(() =>
    //    {
    //        downCounter.CountDown(100);
    //        countdownEvent.Signal();
    //    });

    //    thread1.Start();
    //    thread2.Start();

    //    countdownEvent.Wait();
    //}
}
