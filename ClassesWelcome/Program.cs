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

            Person PersonTwo = new Person("Tim", "Reilly", 43); 
            Console.WriteLine("{0} {1} is aged: {2}", PersonTwo.FirstName, PersonTwo.LastName, PersonTwo.Age); 


            PersonWithProperties personThree = new PersonWithProperties("Bob", "Sacamano", 55); 
            personThree.Age = 18; 
            Console.WriteLine("{0} {1} is aged: {2}", personThree.FirstName, personThree.LastName, personThree.Age); 

            Console.ReadKey(); 

        }
    }
}
