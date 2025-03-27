class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting..." + System.DateTime.Now.ToLongTimeString());
        Thread.Sleep(1000);
        Console.WriteLine("Ending..."+ System.DateTime.Now.ToLongTimeString());

        Thread currentThread = Thread.CurrentThread;
        
        currentThread.Name = "Main";
        
        Console.WriteLine(currentThread.GetHashCode() + ":" + currentThread.Name);
    }
}