using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GenericExtensions;

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
            ServerManager m = new ServerManager(); 
            m.PrintOfflineAsianServersWithLotsOfRamLinq();
            Console.WriteLine("Offline Server in order"); 
            m.PrintOfflineServers();
            Console.ReadKey();
            testExtensions();
            Console.ReadKey();

        }

        private static void testExtensions()
        {
            List<string> colors = new List<string>()
            {
                "blue", "red", "orange", "green"
            }; 

            var stack = colors.ToStack();
            Console.WriteLine("Colors - List: "); 
            foreach(var color in colors) 
            {
                Console.WriteLine($"{color} "); 
            } 
            Console.WriteLine("Colors - stack: "); 
            while(stack.Count > 0) 
            {
                Console.WriteLine($"{stack.Pop()}"); 
            }
        }

        private static void WriteLogs()
        {
            int logFilesAmount = 2;
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
            int logFilesAmount = 2;

            // simpler code with threadpools: 
            for (int i = 0; i < logFilesAmount; i++)
            {
                var logManager = new LogManager($"file-log-{i + 1}.txt");
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
            int tasksAmount = 2;
            Task[] tasks = new Task[tasksAmount]; 
            for (int i = 0; i < tasksAmount; i++)
            {
                string fileName = $"file-log-task-{i+1}"; 
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
