using RestSharp;

namespace SWAPIExample.Models
{
    public class SWAPIDAL
    {

        public SWPerson GetPerson(int id)
        {
            var client = new RestClient($"https://swapi.dev/api/people/{id}/");
            var request = new RestRequest();
            var response = client.GetAsync<SWPerson>(request);
            SWPerson sp = response.Result;

            return sp;
        }
    }
}
