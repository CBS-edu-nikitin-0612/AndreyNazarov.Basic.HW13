using System;
using System.Threading;

namespace Task4
{
    class Program
    {
        private static int count = 100;
        static void Main(string[] args)
        {
            Method();
        }

        static void Method()
        {
            if (count < 0) return;
            count--;
            Thread.Sleep(50);
            Console.WriteLine($"Curent Thread: {Thread.CurrentThread.ManagedThreadId} count: {count}");
            Thread thread = new Thread(Method);
            thread.Start();
        }
    }
}
