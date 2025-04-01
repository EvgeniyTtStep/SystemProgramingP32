class MyClass
{
    public static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(ThreadMethod);
        Thread thread = new Thread(threadStart);
        Console.WriteLine("Thread Main started");
        thread.Start();
        Thread.Sleep(500);
        Console.WriteLine("Thread Main waiting...");
        thread.Join();
        Console.WriteLine("Thread Main finished");
    }
    static void ThreadMethod()
    {
        Console.WriteLine("Thread method started");
        Thread.Sleep(2000);
        Console.WriteLine("Thread method finished");
    }
}