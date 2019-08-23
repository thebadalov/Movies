using Movie.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Contract.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieModel>> GetMoviesAsync();

        Task CreateMovie(MovieModel model);
    }
}
