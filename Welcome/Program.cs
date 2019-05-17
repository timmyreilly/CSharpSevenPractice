using System;
using System.Text;

namespace CSharpSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 42;
            uint myUnsigned = 10000;
            char[] charArray = new char[] { 'a', 'b', 'c' };
            Console.WriteLine(charArray.Length);
            char[] charArrayTw = new char[4];
            Console.WriteLine(charArrayTw.Length);
            Console.WriteLine("myInt = {0}", myInt);

            // string are immutable 
            // don't do this: string result = "";
            // do this: 
            StringBuilder builder = new StringBuilder();



            while (true)
            {
                Console.WriteLine("Type a word: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    builder.Append(input + " ");
                }
            }

            // you should use string builder. Adds them to the back of the list of strings. 



            Console.WriteLine("Result: {0}", builder.ToString());
            Console.ReadKey();

        }
    }
}
