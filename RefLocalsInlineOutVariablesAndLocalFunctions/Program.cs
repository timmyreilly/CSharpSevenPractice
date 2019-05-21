using System;
using System.Collections.Generic;

namespace RefLocalsInlineOutVariablesAndLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Smith", 27); 
            int age = p.GetAge(); 
            ref int ageRef = ref p.GetAge(); 
            age++;
            Console.WriteLine(p);
            ageRef++;  
            Console.WriteLine(p);

            int sum, diff; 
            calculate(8, 2, out sum, out diff); 
            Console.WriteLine($"Sum: {sum}"); 
            Console.WriteLine($"Dif: {diff}"); 
            calculate(8, 2, out int s, out int d);
            Console.WriteLine($"S: {s}"); 
            Console.WriteLine($"D: {d}");
            // wow! Inline out variables. SYNTAX SUGAR: 
            calculate(8, 3, out var v, out var vTwo); 
            Console.WriteLine($"v: {v}"); 
            Console.WriteLine($"vTwo: {vTwo}");
             
            Console.ReadKey(); 
        }

        // private static ref double getDoubleRef() 
        // {
        //     double value = 3.14;
        //     // you cannot return a reference to a local value variable. These are stored on the stack. 
        //     // You cannot ref return in Async methods
             
        //     //return ref value;
           
        // }

        // Inline Out Variables 
        // Video out variables can be initialized when calling a method. 
        private static void calculate(int a, int b, out int sum, out int diff) 
        {
            sum = a + b; 
            diff = a - b; 
        }


    }
}
