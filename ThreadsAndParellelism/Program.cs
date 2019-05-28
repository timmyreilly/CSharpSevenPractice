using System;
using System.Threading;

namespace ThreadsAndParellelism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLogs();
            WriteLogsWithPools(); 
            Console.ReadKey();
        }

        private static void WriteLogs()
        {
            int logFilesAmount = 10;
            Thread[] threads = new Thread[logFilesAmount];
            Console.WriteLine("Starting writer threads...");
            for (int i = 0; i < logFilesAmount; i++)
            {
                var logManager = new LogManager($"FileNumber{i + 1}");
                threads[i] = new Thread(logManager.Generate);
                threads[i].Start();
            }

            for (int i = 0; i < logFilesAmount; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("All writer threads finished");
        }

        // ThreadPool and preconfigured by framework. Quickly assign it to a secondary thread by queueing it to the pool. 

        private static void WriteLogsWithPools()
        {
            int logFilesAmount = 10;

            // simpler code with threadpools: 
            for (int i = 0; i < logFilesAmount; i++)
            {
                var logManager = new LogManager($"log-{i + 1}.txt");
                ThreadPool.QueueUserWorkItem(new WaitCallback((o) =>
                {
                    logManager.Generate();
                }));
            }

        }
    }
}
