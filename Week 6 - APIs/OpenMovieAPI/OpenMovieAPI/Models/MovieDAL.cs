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
    }
}
