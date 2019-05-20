using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile();
            writeFile();
            UsingReadFile();
            UsingReadFileWhoops(); 
            Console.ReadKey();
        }

        private static void readFile()
        {
            StreamReader reader = new StreamReader("test.txt");
            string context = reader.ReadToEnd();
            Console.WriteLine(context);
            reader.Close();
        }

        private static void writeFile()
        {
            StreamWriter writer = new StreamWriter("test-text.txt", false);
            writer.WriteLine("VS COde is great");
            writer.Close();
        }

        private static void UsingReadFile()
        {
            using (StreamReader reader = new StreamReader("test-text.txt"))
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
        }

        private static void UsingReadFileWhoops()
        {
            try
            {

                using (StreamReader reader = new StreamReader("test-not-there.txt"))
                {
                    string contents = reader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(FileNotFoundException e) 
            {
                Console.WriteLine("File not found"); 
            }
            catch(FileLoadException e) 
            {
                Console.WriteLine("File load failed"); 
            }
            catch(Exception) 
            {
                Console.WriteLine("File operation failed"); 
            }
        }

        private static async void UsingReadFileAsync()
        {
            using (StreamReader reader = new StreamReader("test-text.txt"))
            {
                string contents = await reader.ReadToEndAsync();
                Console.WriteLine(contents);
            }
        }
    }
}
