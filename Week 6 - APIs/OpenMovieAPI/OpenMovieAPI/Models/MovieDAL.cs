using RestSharp;
using static System.Net.WebRequestMethods;

namespace OpenMovieAPI.Models
{
    public class MovieDAL
    {
        public string key = "62398519";
        public Results SearchMovies(string title)
        {
            string url = $"https://www.omdbapi.com/?s={title}&apikey={key}";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync<Results>(request);
            Results sp = response.Result;

            return sp;

        }

        public Movie GetMovieById(string id)
        {
            string url = $"https://www.omdbapi.com/?i={id}&apikey={key}";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            var reponse = client.GetAsync<Movie>(request);

            Movie movie = reponse.Result;
            return movie;
        }
    }
}
