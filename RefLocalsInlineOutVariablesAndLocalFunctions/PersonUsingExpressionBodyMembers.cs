using System;

namespace RefLocalsInlineOutVariablesAndLocalFunctions
{
    public class PersonUsingExpressionBodyMembers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // This is a readonly only property: 
        // public string FullName
        // {
        //     get
        //     {
        //         return $"{FirstName} {LastName}";
        //     }
        // }

        // Expression body becomes: 
        public string FullName => $"{FirstName} {LastName}"; 

        private int _age; 

        public int Age
        {
            get
            {
                return _age; 
            }
            set 
            {
                _age = value; 
            }
        }

        public PersonUsingExpressionBodyMembers(string firstname, string lastName, int age) 
        {
            FirstName = firstname; 
            LastName = lastName; 
            Age = age; 
        }

        ~PersonUsingExpressionBodyMembers()
        {
            Console.WriteLine("Finalizing Person"); 
        }

        // public override string ToString()
        // {
        //     return FullName; 
        // }
        // This is a block body... 

        // This is an expression body: 
        public override string ToString() => FullName; 

        
    }
}