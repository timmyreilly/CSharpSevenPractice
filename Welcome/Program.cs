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


            myMethod(); 
            printNumber(534); 
            printNum(4); 
            printNum(5, 4); 
            Console.WriteLine("Result: {0}", builder.ToString());


            double myDouble = 4.56; 
            Console.WriteLine("myDouble in Main: {0}", myDouble); 
            incrementDouble(myDouble);

            Console.WriteLine("myDouble in Main: {0}", myDouble); 

            incrementDouble( ref myDouble); // we've overloaded this method to support a pass by reference
            Console.WriteLine("myDouble after a call to reference: {0}", myDouble); 

            StringBuilder builderTwo = new StringBuilder(); 
            builderTwo.Append("hello"); 
            builderTwo.Append("c%"); 

            addExclamationMarks(builderTwo); // this guy is passed by reference! 

            Console.WriteLine("String builder in Main: {0}", builderTwo.ToString());  
            Console.ReadKey();

        }

        private static void addExclamationMarks(StringBuilder b)
        {
            b.Append("!!!!!"); 
        }

        private static void incrementDouble(double myDouble)
        {
            myDouble++; 
            Console.WriteLine("myDouble in incrementDouble: {0}", myDouble); 

        }

        private static void incrementDouble(ref double myDouble)
        {
            myDouble++; 
            Console.WriteLine("myDouble in incrementDouble: {0}", myDouble); 

        }

        static void myMethod() 
        {
            Console.WriteLine("THIS IS MY SHINY NEW METHOD"); 
        }

        static void myMethod(int a)
        {
            Console.WriteLine("This is my... a {0}", a); 
        }

        static void printNum(int a) 
        {
            Console.WriteLine(a); 
        }

        static void printNum(int a, int b) 
        {
            int result = a + b; 
            Console.WriteLine(result); 
        }

        static void printNumber(int num)
        {
            Console.WriteLine("Number: {0}", num); 
        }

        // value types - stored on the stack, derive from System.ValueType - Destroyed when the method that declared them goes out of scope
                // Copies of them passed to methods 
        // reference types - derive directly from System.Object - garbage collected
                // Passed to methods as they are...  you pass a pointer. 
                // This is the most important. 
    }
}
