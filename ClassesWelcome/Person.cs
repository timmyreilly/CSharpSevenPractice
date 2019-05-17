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
    }
}