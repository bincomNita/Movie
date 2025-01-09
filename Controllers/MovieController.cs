using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        public IEnumerable<MovieItem> TheMovies = [
            new MovieItem{ Title="Titnanic",Description="description",ReleaseDate=new DateOnly(1999,5,22),Rating=9,Price=78},
            new MovieItem{ Title="Pani",Description="description",ReleaseDate=new DateOnly(2025,5,22),Rating=9,Price=85}
            ];
        public IActionResult GetMovies()
        {
            return View(TheMovies);
        }
    }
}
