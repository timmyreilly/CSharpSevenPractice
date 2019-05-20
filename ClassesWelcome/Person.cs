using System;

namespace ClassesWelcome
{
    public class Person
    {
        // access modifiers: 
        // public - accessible by every other class
        // private - only the class 
        // protected - accessible to the class and derived 'sub-classes'
        // internal - can only be used by classes in the same assembly. 

        public string FirstName;
        public string LastName;
        public int Age;

        private decimal salary;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age, decimal salary = 45000)
        {
            FirstName = firstName;
            this.LastName = lastName;
            this.Age = age; // we can omit this if we want. 
            this.salary = salary;
        }


        // how about some properties. 
    }

    public class PersonUsingComposition  {
        public static int MinAge = 18;
        public static int MaxAge = 70;

        private readonly string _firstName;
        private readonly string _lastName; // backing fields can only be set with constructor

        private IRun _runner; 

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public int Age { get; set; }

        private decimal _salary;

        public PersonUsingComposition(string firstName, string lastName, int age, IRun runner, decimal salary = 45000)
        {
            _firstName = firstName;
            _lastName = lastName;
            _runner = runner; 
            Age = age;

            // default value
            _salary = salary;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello I am a Person");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " age, " + Age; 
        }

        public void Run(int distance)
        {
            _runner.Run(4); 
        }
    }

    public class PersonWithProperties : IRun // demonstration of a is-a relationship
    {

        // static for all PersonWithProperties 
        // all person are adults and younger than 70 for all 
        public static int MinAge = 18;
        public static int MaxAge = 70;

        private readonly string _firstName;
        private readonly string _lastName; // backing fields can only be set with constructor

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public int Age { get; set; }

        private decimal _salary;

        public PersonWithProperties(string firstName, string lastName, int age, decimal salary = 45000)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;

            // default value
            _salary = salary;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello I am a Person");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " age, " + Age; 
        }

        public void Run(int distance)
        {
            Console.WriteLine("I am running for {0} kilometers", distance); 
        }
    }
}