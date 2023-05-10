using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        // a list of movies.
        public SelectList? Genres { get; set; }
        // contains a list of genres.
        public string? MovieGenre { get; set; }
        // contains selected genre.
        public string? SearchString { get; set; }
        // contains the text users enter in the search text box.
    }
}
