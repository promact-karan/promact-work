using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                using (var httpClient = new HttpClient())
                {
                    var task = httpClient.GetAsync("https://www.gobymobile.com/sitemap.xml");
                    Console.WriteLine("Call is getting executed asynchronously while get async method is executing");
                    Console.WriteLine();
                    Console.WriteLine("another console log");
                    await task;
                    Console.WriteLine("after await synchronous call continue");
                }                
            });
            Console.Read();
        }
    }
}
