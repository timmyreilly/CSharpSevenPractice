using System;

namespace ClassesWelcome
{
    public class SlowRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine("Taking it slow for {0} kilometers", distance); 
        }
    }
}