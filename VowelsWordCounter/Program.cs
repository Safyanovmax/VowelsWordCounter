using System;
using System.IO;
using VowelsWordCounter.Implementations;

namespace VowelsWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string input = Console.ReadLine();
            string path = Path.Combine(Environment.CurrentDirectory, input);

            var app = new CounterApp(new FileProcessor(), new WordsProcessor());
            var count = 0;

            try
            {
                count = app.Count(path).Result;
                Console.WriteLine($"Count of words that have only vowels: {count}");
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException is FileNotFoundException)
                    Console.WriteLine("File not found");
                else
                    Console.WriteLine("Something went wrong");
            }
        }
    }
}
