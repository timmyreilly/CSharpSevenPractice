using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

            // Digit Seperators 

            int number = 1_750_036;
            int sameNumber = 1750036; 
            // These are equivalent ^ These seperators "_" have no effect.  
            double specificNumber = 1_123_123.54; 

            int myBinary = 0b0010; 
            Console.WriteLine($"Your Binary {myBinary}"); 
            int moreBinary = 0b1000_0010; 
            Console.WriteLine($"Your Binary {moreBinary}"); 

             
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

        private static async Task<bool> getBoolOldWayAsync()
        {
            // This is inefficient because we need to instantiate a value of type Task everytime. 
            await Task.Delay(3000); 
            return false; 
        }

        private static async ValueTask<bool> getBoolAsyncNewWay() 
        {
            // ValueTask<T> is a struct and will be allocated on the stack, which is faster.  
            // ValueTask is a value type. 
            await Task.Delay(3000);
            return true; 
        }

        



    }
}
