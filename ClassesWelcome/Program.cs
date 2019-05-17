using System;

namespace ClassesWelcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); 
            person.FirstName = "John"; 
            person.LastName = "Smith";
            person.Age = 55; 
            Console.WriteLine("{0} {1} is aged: {2}", person.FirstName, person.LastName, person.Age); 
        }
    }
}
