using Microsoft.AspNetCore.Mvc;
using Movie.Contract.Services;
using System.Threading.Tasks;

namespace Movie.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetMoviesAsync();

            return View(movies);
        }
    }
}