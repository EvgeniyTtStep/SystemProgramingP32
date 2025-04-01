// class ThreadResume
// {
//     public static void Main(string[] args)
//     {
//         ThreadStart threadStart = new ThreadStart(ThreadMethod);
//         Thread thread = new Thread(threadStart);
//         thread.Start();
//         Console.WriteLine("Press any key to pause");
//         Console.ReadKey();
//         thread.Suspend(); //deprecated
//         Console.WriteLine("The thread is suspended");
//         Console.WriteLine("Press any key to resume");
//         Console.ReadKey();
//         thread.Resume(); //deprecated
//     }
//
//
//     static void ThreadMethod()
//     {
//         for (int i = 0; i < 100; i++)
//         {
//             Console.WriteLine(i);
//             Thread.Sleep(1000);
//         }
//     }

using System;
using System.Threading;

class ThreadResume
{
    static ManualResetEvent pauseEvent = new ManualResetEvent(true);
    

    public static void Main(string[] args)
    {
        Thread thread = new Thread(ThreadMethod);
        thread.Start();
        Console.WriteLine("Press any key to pause");
        Console.ReadKey();
        pauseEvent.Reset(); // Зупинка потоку

        Console.WriteLine("\nThe thread is suspended");
        Console.WriteLine("Press any key to resume");
        Console.ReadKey();
        pauseEvent.Set(); // Продовження потоку
        Console.WriteLine("Press any key to Abort");
        Console.ReadKey();
        thread.Abort();//не працює!!!!
        
    }

    static void ThreadMethod()
    {
        try
        {
            for (int i = 0; i < 100; i++)
            {
                pauseEvent.WaitOne(); // Очікує сигналу для продовження
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

        }
        finally 
        {
            Console.WriteLine("The thread is aborted");
        }
        
    }
}