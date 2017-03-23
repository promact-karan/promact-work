using System;
using System.Linq;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

            //Get only short words
            //Query method
            var queryMethodShortWords = from word in words
                                        where word.Length <= 5
                                        select word;

            //Print each word out
            Console.WriteLine("Output of query method");
            foreach (var word in queryMethodShortWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Output of lambda method");
            words.Where(x => x.Length <= 5).ToList().ForEach(word =>
            {
                Console.WriteLine(word);
            });

            Console.ReadLine();
        }
    }
}
