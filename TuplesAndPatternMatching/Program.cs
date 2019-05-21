using System;

namespace TuplesAndPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = getCar(); 
            Console.WriteLine($"Model: {car.Item1}"); 
            Console.WriteLine($"Cost: {car.Item2}"); 
            Console.WriteLine($"Currency: {car.Item3}"); 
            Console.WriteLine(getCar());

            var namedCar = getCarWithNamedTuples(); 

            Console.WriteLine($"Model: {namedCar.Model}"); 
            Console.WriteLine($"Price: {namedCar.Price}"); 
            Console.WriteLine($"Currency: {namedCar.Currency}"); 

            (string model, double price, string currency) = getCarWithNamedTuples(); 

            Console.WriteLine("Deconstruction"); 

            Console.WriteLine($"model: {model}"); 
            Console.WriteLine($"price: {price}"); 
            Console.WriteLine($"currency: {currency}");

            Person p = new Student("John", "Smith", 23, StudentLevel.HighSchool); 
            describePerson(p); 
            Person e = new Employee("Bob", "Sacamano", 43, EmployeeType.Hourly); 
            describePerson(e); 
            describeEmployeeIs(e); 
            Console.ReadKey(); 

        }

        private static void describePerson(Person p) 
        {
            switch(p) 
            {
                case Student s when s.Level == StudentLevel.HighSchool: 
                    Console.WriteLine($"{s} is a high school student"); 
                    break; 
                case Student s when s.Level == StudentLevel.Undergrad: 
                    Console.WriteLine($"{s} is an undergraduate student"); 
                    break; 
                case Student s when s.Level == StudentLevel.Postgrad: 
                    Console.WriteLine($"{s} is a graduate student"); 
                    break; 
                case Employee e: 
                    Console.WriteLine($"{e} is an employee");
                    break; 
                case Athlete a: 
                    Console.WriteLine($"{a} is an athlete"); 
                    break;
                case Person person: 
                    Console.WriteLine($"{p} is just a person"); 
                    break; 
                default: 
                    throw new ArgumentException("You need to pass a person to this method");  
            }
            // The order matters! The person check switch would always be called! Make sure the most generic is last on your switch statement. 
        }

        private static void describeEmployeeIs(Person p) 
        {
             if(p is Employee e) 
             {
                 if(e.Type == EmployeeType.Hourly)
                 {
                     Console.WriteLine($"{e} is an hourly employee"); 
                 } 
                 else 
                 {
                     Console.WriteLine($"{e} is a salaried employee"); 
                 }
             }
        }

        private static (string, double, string) getCar() {
            return ("hello", 12.32, "world"); 

        }

        private static (string Model, double Price, string Currency) getCarWithNamedTuples()
        {
            return ("Tesla", 123000, "USD"); 
        }

        // Deconstruction, quick way to copy the values to individual variables. 

    }
}
