class Program
{

    public static void Main(string[] args)
    {
        ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadMethod);
        Thread thread1 = new Thread(threadStart);
        Thread thread2 = new Thread(threadStart);
        
        thread1.Priority = ThreadPriority.Lowest;
        thread2.Priority = ThreadPriority.Highest;
        
        thread1.Start(" First");
        thread2.Start(" Second");

    }

    static void ThreadMethod(object str)
    {
        string message = str.ToString();
        for (int i = 0; i < 2000; i++)
        {
            Console.WriteLine("{0} #{1}",message, i.ToString());
        }
        
    }
}