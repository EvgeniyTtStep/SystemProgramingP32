class ThreadExample
{
    public static void Main(string[] args)
    {
        ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadMethod);
        
        Thread thread1 = new Thread(threadStart);
        thread1.Start("First");
        
        Thread thread2 = new Thread(threadStart);
        thread2.Start("\t\tSecond");
        
    }
    public static void ThreadMethod(object a)
    {
        string ID = (string)a;
        
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("\t\tHello Thread " + ID);
        }
    }
}