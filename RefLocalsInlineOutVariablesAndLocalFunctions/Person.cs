namespace RefLocalsInlineOutVariablesAndLocalFunctions
{
    public class Person
    {
        public string LastName; 
        public string FirstName; 
        private int _age; 

        public Person(string firstName, string lastName, int age) 
        {
            FirstName = firstName; 
            LastName = lastName;
            _age = age; 
        }

        public ref int GetAge() 
        {
            return ref _age; 
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {_age}"; 
        }
    }
}