using Microsoft.AspNetCore.Mvc;
using Movie.Contract.Services;
using Movie.Web.Models;
using System.Diagnostics;

namespace Movie.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService; // servis çagırma
        private readonly ISeriesService _seriesService;

        public HomeController(IMovieService movieService, ISeriesService seriesService)
        {
            _movieService = movieService;
            _seriesService = seriesService;
        }


        public IActionResult Index()
        {

            
            /* var context = new MovieContext();
                 var movies =
                     await context.Movie
                     .Select(x => new MovieViewModel
                     {
                         Title = x.Title,
                         MovieType = x.MovieType,
                         MovieKind = x.MovieKind,
                         Duration = x.Duration,


                     }).ToListAsync();  */

            return View();
        }


        //public IActionResult Movie()
        //{
        //    var movies = _movieService.GetMovies();

        //    return View();
        //}
        //public IActionResult Series()
        //{

        //    var series = _seriesService.GetSeries();

        //    return View();
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
