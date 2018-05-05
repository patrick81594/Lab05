using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Lab05.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string MovieGenre { get; set; }
    }
}