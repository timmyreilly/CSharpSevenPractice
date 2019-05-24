using System;
using System.IO;

namespace DelegatesLambdaAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            machine.RegisterTempWatcher(LogTempToConsole);
            machine.RegisterTempWatcher(LogTempToFile);
            machine.RegisterTempWatcher((double prev, double current) =>
            {
                Console.WriteLine($"Temperature changed from {prev} to {current} we're observing this from our lambmda");
            });

            machine.RegisterTempWatcher(async (double prev, double current) =>
            {
                using (StreamWriter writer = new StreamWriter("temp.txt", true))
                {
                    await writer.WriteLineAsync($"Machine temperature changed from {prev} to {current}");
                }
            });
            machine.TurnOn();
            Console.ReadKey();
        }

        private static void LogTempToConsole(double prev, double current)
        {
            Console.WriteLine($"Current temp: {current} Previous Temp: {prev}");
        }

        private static async void LogTempToFile(double prev, double current)
        {
            using (StreamWriter writer = new StreamWriter("temp.txt", true))
            {
                await writer.WriteLineAsync($"Michine temperature changed from {prev} to {current}");
            }
        }
    }
}
