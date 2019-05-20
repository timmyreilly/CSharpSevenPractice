namespace ClassesWelcome
{
    public class FastRunner : IRun
    {
        public void Run(int distance)
        {
            System.Console.WriteLine("Running fast for {0} kilometers", distance); 
        }
    }
}