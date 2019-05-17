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

        public Person(string firstName, string lastName, int age, decimal salary=45000)
        {
            FirstName = firstName;
            this.LastName = lastName;
            this.Age = age; // we can omit this if we want. 
            this.salary = salary;
        }

        // how about some properties. 
    }

    public class PersonWithProperties 
    {
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

        public int Age{ get; set; }

        private decimal _salary; 

        public PersonWithProperties(string firstName, string lastName, int age, decimal salary = 45000)
        {
            _firstName = firstName; 
            _lastName = lastName; 
            Age = age; 

            // default value
            _salary = salary; 
        }
    }
}