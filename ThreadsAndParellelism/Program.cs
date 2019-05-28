using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndParellelism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLogs();
            WriteLogsWithPools();
            WriteFilesWithTPL(); 
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

        // using TPL (Task Parallel Library) 
        // TPL .NET 4.0 Async for a task. A more efficient way, and working at a higher level. 

        private static void WriteFilesWithTPL()
        {
            int tasksAmount = 10;
            Task[] tasks = new Task[tasksAmount]; 
            for (int i = 0; i < tasksAmount; i++)
            {
                string fileName = $"log-task-file-{i+1}"; 
                int id = i + 1; 
                tasks[i] = Task.Run(() => {
                    Console.WriteLine($"Task {i + 1} actually you want id: {id} running on thread {Thread.CurrentThread.ManagedThreadId} / writing file: {fileName}"); 
                    var generator = new ReportGenerator(fileName); 
                    generator.Generate(); 
                }); 

            }
            Task.WaitAll(tasks); 
            Console.WriteLine("Writing tasks finished"); 
        }
    }
}
