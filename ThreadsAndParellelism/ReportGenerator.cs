using System.IO;

namespace ThreadsAndParellelism
{
    public class ReportGenerator
    {
        private string FileName; 
        public ReportGenerator(string fileName) 
        {
            FileName = fileName; 
        }

        public void Generate() 
        {
            using(StreamWriter writer = new StreamWriter(FileName))
            {
                writer.WriteLine("YOOOOOO"); 
                
            }
        }
    }
}