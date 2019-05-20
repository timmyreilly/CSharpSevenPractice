using System;

namespace EnumsStructsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("star wars", 1977, MovieGenre.SciFi);
            PrintGenre(movie);

            Coordinates c = new Coordinates();
            c.Latitude = 53.3142;
            c.Longitude = 43.1234;
            Console.WriteLine("I am here {0} {1}", c.Longitude, c.Latitude);
            // Structs versus Classes
            // structs are value types stored on the stack 
            // Classes are stored on the heap. 
            // No explicit parameterless constructors. 
            // Structs do not support inheritance. Value types... are very important difference. 
            changeCoordinates(c);
            Console.WriteLine("I am here {0} {1}", c.Longitude, c.Latitude);
            changeCoordinatesByReference(ref c);
            Console.WriteLine("I am here {0} {1}", c.Longitude, c.Latitude);

            // Working with a generic stack
            MyStack<string> friends = new MyStack<string>(); 
            friends.Push("Bob"); 
            friends.Push("Steve"); 
            friends.Push("Frank"); 

            while(!friends.IsEmpty())
            {
                Console.WriteLine(friends.Pop()); 
            }

            MyStack<int> randomNumbers = new MyStack<int>(); 
            Random rdm = new Random(); 
            randomNumbers.Push(rdm.Next(0, 10)); 
            randomNumbers.Push(rdm.Next(0, 10)); 
            randomNumbers.Push(rdm.Next(0, 10)); 

            Console.ReadKey();
        }

        private static void changeCoordinatesByReference(ref Coordinates c)
        {
            c.Longitude = 0;
            c.Latitude = 0;
        }

        private static void changeCoordinates(Coordinates c)
        {
            c.Longitude = 0;
            c.Latitude = 0;
        }


        static void PrintGenre(Movie movie)
        {
            switch (movie.Genre)
            {
                case MovieGenre.SciFi:
                    Console.WriteLine("SciFi");
                    break;
                default:
                    Console.WriteLine("it was something else");
                    break;
            }

        }
    }
}
