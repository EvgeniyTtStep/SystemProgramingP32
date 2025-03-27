class Program
{
    public static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(ThreadMethod);
        Thread thread = new Thread(threadStart);
        
        thread.IsBackground = true;
        
        thread.Start();
        
        Console.WriteLine("Thread started, press any key to exit...");
        Console.ReadKey();
        
    }

    public static void ThreadMethod()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread " + i );
        }
        Console.WriteLine("Fone Thread finished");
    }
}