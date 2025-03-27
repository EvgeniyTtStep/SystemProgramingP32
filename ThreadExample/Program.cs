class ThreadExample
{
    public static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(ThreadMethod);
        Thread thread = new Thread(threadStart);
        thread.Start();
        
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("\t\tHello Main");
        }
        
    }
    public static void ThreadMethod()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("\t\t\t\tHello Thread");
        }
    }
}