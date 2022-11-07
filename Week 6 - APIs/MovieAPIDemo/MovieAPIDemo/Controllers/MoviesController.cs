using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPIDemo.Models;

namespace MovieAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly APIMoviesDbContext _context;

        public MoviesController(APIMoviesDbContext context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet("Category/{category}")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesByCategory(string category)
        {
            return await _context.Movies.Where(m => m.Category == category).ToListAsync();
        }

        [HttpGet("RandomMovie")]
        public Movie GetRandomMovie()
        {
            Random random = new Random();
            int selection = random.Next(_context.Movies.Count());
            Movie m = _context.Movies.ToList().ElementAt(selection);
            return m;
        }

        [HttpGet("RandomCategory/{category}")]
        public Movie GetRandMovByCat(string category)
        {
            Random random = new Random();
            int selection = random.Next(_context.Movies.Where(m => m.Category == category).Count());
            return _context.Movies.ToList().ElementAt(selection);
        }

        [HttpGet("RandomMovies/{number}")]
        public List<Movie> GetRandMovies(int number)
        {
            List<Movie> randomMovies = new List<Movie>();
            List<Movie> movies = _context.Movies.ToList();
            Random random = new Random();

           for(int i =0; i< number; i++)
           {
                int selection = random.Next(movies.Count);
                randomMovies.Add(movies[selection]);
                movies.RemoveAt(selection);
           }
            
            return randomMovies;
        }

        [HttpGet("AllCategories")]
        public List<string> GetAllCategories()
        {
            List<string> allCategories = _context.Movies.Select(m => m.Category).ToList();
            List<string> splitCategories = new List<string>();
            foreach(string category in allCategories)
            {
                string[] categories = category.Split('|');
                splitCategories.AddRange(categories);
            }
            return splitCategories.Distinct().ToList();
        }

        [HttpGet("LookUpMovie/{title}")]
        public Movie LookUpTitle(string title)
        {

            IEnumerable<Movie> movie = _context.Movies.Where(m => m.Name == title);

            if(movie.Any())
            {
                return movie.First();
            }
            else
            {
                return new Movie();
            }
        }

        [HttpGet("SearchTitle/{title}")]
        public IEnumerable<Movie> SearchTitles(string title)
        {
            return _context.Movies.Where(m => m.Name.Contains(title));
        }




        // PUT: api/Movies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
