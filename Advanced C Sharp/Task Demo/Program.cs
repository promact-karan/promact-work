using System;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Hello from first Task - {Thread.CurrentThread.ManagedThreadId}");

            });

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Hello from second Task - {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"Hello from Main - {Thread.CurrentThread.ManagedThreadId}");
            Console.Read();
        }
    }
}
