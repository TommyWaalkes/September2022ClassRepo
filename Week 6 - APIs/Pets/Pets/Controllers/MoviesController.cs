using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pets.Models;

namespace Pets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly Movies2Context _context;

        public MoviesController(Movies2Context context)
        {
            _context = context;
        }
        //Write a API Endpoint that takes a string for title, and returns all movies with a similar title

        //By using the {} I've set this action up to expect a title as a parameter 
        //Linq is your friend with API calls 
        [HttpGet("SearchByTitle/{title}")]
        public async Task<ActionResult<IEnumerable<Movie>>> SearchByTitle(string title){
            return await _context.Movies.Where(m => m.Title.Contains(title)).ToListAsync();
        }

        [HttpGet("SearchByGenre/{genre}")]
        public async Task<ActionResult<IEnumerable<Movie>>> SearchByMovie(string genre)
        {
            return await _context.Movies.Where(m => m.Genre.Contains(genre)).ToListAsync();
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

        //In API controller you may write non-endpoint helper methods 
        //Examples of helper methods: 
        //Validation - for rare cases SQL and C# can't cover something 
        //Sorting or format output - say you only want the movie titles in alphabetical order 
        //These helpers exist to be called by endpoints, but can't be called directly by HTTP 
        //Helpers need to be private, as any public method in the API controller is treated as an endpoint
        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }

        //This method handles creating the endpoint 
        [HttpGet("GetTitles")]
        public async Task<ActionResult<IEnumerable<String>>> GetTitlesAlphabetical()
        {
            return  GetTitles(); 
        }

        //this method handles the functionality 
        private List<string> GetTitles()
        {
            List<string> titles = new List<string>();
            List<Movie> movies = _context.Movies.ToList();

            foreach(Movie m in movies)
            {
                titles.Add(m.Title);
            }
            titles.Sort();
            return titles;
        }
    }
}
