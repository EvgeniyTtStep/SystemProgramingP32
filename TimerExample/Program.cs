



class TimerEx
{
    public static void Main(string[] args)
    {
        TimerCallback callback = new TimerCallback(TimerMethod);
        Timer timer = new Timer(callback);
        timer.Change(1000, 1000);

        Console.ReadKey();
    }
    
    public static void TimerMethod(object s)
    {
        Console.WriteLine("TimerMethod");
    }
}

