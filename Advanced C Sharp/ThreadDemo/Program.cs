using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(ExecuteLongTask);
            thread.Start();
            thread.IsBackground = true;
            //ExecuteLongTask();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("From Main Thread : " + i);
                Thread.Sleep(200);
            }
            Console.Read();
        }

        static void ExecuteLongTask()
        {
            string str = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("From Child Thread : " + i);
                Thread.Sleep(500);
            }
            Console.Read();
        }
    }
}