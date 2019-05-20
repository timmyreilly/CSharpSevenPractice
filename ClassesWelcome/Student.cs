using System;

namespace ClassesWelcome
{
    public class Student : PersonWithProperties
    {

        public string University { get; set; }
        public double AvgGrade {get; set; }

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public override void SayHello(){
            Console.WriteLine("Wazzup from student life"); 
        }
        
    }
}