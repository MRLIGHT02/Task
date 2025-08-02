class UpCounter {

    public void CountUp(int count)
    {
        Console.WriteLine("Counting up Started:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Count Up: {i + 1}");
        }
        Console.WriteLine("Counting up Finished");
    }

}

class DownCounter {

    public void CountDown(int count)
    {
        Console.WriteLine("Counting Down Started:");
        for (int j = count; j <= 1; j--)
        {
            Console.WriteLine($"Count Down: {j + 1}");
        }
        Console.WriteLine("Counting Down Finished");
    }
}


class Program
{
    static void Main()
    {
    // c
    }
}