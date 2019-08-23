using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Movie.Contract.Models;
using Movie.Contract.Services;
using Movie.Data.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieContext _movieContext;

        public MovieService(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }


        public async Task CreateMovie(MovieModel model)
        {
            var mapModel = Mapper.Map<Entities.Movie>(model);

            await _movieContext.Movie.AddAsync(mapModel);

           await _movieContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MovieModel>> GetMoviesAsync()
        {
           var movies = await _movieContext.Movie.ToArrayAsync();

            return Mapper.Map<IEnumerable<MovieModel>>(movies);
        }        
    }
}