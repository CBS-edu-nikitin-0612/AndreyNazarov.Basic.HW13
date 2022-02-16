using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            byte[] lockLine = new byte[Console.WindowWidth];
            object lockConsole = new object();
            var rnd = new Random();
            while (true)
            {
                Thread.Sleep(30);
                int i = rnd.Next(0, lockLine.Length);
                if (lockLine[i] == 1)
                {
                    continue;
                }
                new Line(rnd.Next(4, 10), i, lockConsole, ref lockLine);
            }
        }
    }
}
