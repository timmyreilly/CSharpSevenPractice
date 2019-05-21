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
            personThree.Age = 17;
            if (personThree.Age < PersonWithProperties.MinAge)
            {
                Console.WriteLine("Too Young");
            }

            Student std = new Student("John", "Wick", 44);
            std.University = "Seattle U";
            std.AvgGrade = 8;

            std.SayHello();
            Console.WriteLine(std);

            std.Run(5);

            PersonUsingComposition slow = new PersonUsingComposition("John", "Smith", 54, new SlowRunner());
            PersonUsingComposition fast = new PersonUsingComposition("Annie", "Smith", 54, new FastRunner());
            slow.Run(4);
            fast.Run(5);

            // how would we make a person run. 

            Dog d = new Dog("Max", new FastRunner());
            d.Run(54);

            // let's throw some exceptions. 
            try
            {

                PersonUsingComposition exceptionalPerson = new PersonUsingComposition("Cosmos", "Kramer", 43, null);
                exceptionalPerson.Run(4);
            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine("Runner cannot be null");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ooops {e}");
            }

            Console.ReadKey();

        }
    }
}
