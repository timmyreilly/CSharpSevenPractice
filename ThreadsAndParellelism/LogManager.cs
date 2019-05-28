using System.IO;

namespace ThreadsAndParellelism
{
    public class LogManager
    {

        public string FileName; 
        public LogManager(string fileName) 
        {
            FileName = fileName; 
        }

        public void Generate() 
        {
            using(StreamWriter writer = new StreamWriter(FileName))
            {
                for(int i = 0; i < 1000; i++)
                {
                    writer.WriteLine($"Line # {i+1}"); 
                }
            }
        }
    }
}