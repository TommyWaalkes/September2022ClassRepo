using RestSharp;

namespace RedditLab.Models
{
    public class RedditDAL
    {
        public Rootobject GetPost()
        {
            var client = new RestClient($"https://www.reddit.com/r/aww/.json");
            var request = new RestRequest();
            var response = client.GetAsync<Rootobject>(request);
            Rootobject sp = response.Result;
            return sp;
        }
    }
}
