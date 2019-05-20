namespace EnumsStructsAndGenerics
{
    public enum MovieGenre {
        Action, 
        Horror, 
        Comedy, 
        SciFi
    }
    public class Movie
    {
        public string Title; 
        public int Year; 
        public MovieGenre Genre; 
        public Movie(string movieName, int releaseDate, MovieGenre genre )
        {
            Title = movieName; 
            Year = releaseDate; 
            Genre = genre; 
        } 
    }
}