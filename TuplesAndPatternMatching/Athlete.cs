namespace TuplesAndPatternMatching
{
    public enum SportType
    {
        Individual,
        Team
    }
    public class Athlete : Person
    {
        public SportType SportType { get; set; }
        public Athlete(string firstName, string lastName, int age, SportType type) : base(firstName, lastName, age)
        {
            SportType = type;

        }
    }
}