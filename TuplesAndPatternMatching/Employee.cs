namespace TuplesAndPatternMatching
{
    public enum EmployeeType
    {
        Salaried,
        Hourly
    }

    public class Employee : Person
    {
        public EmployeeType Type { get; set; }
        public Employee(string firstName, string lastName, int age, EmployeeType type) : base(firstName, lastName, age)
        {
            Type = type; 
        }
    }
}