using RestSharp;

namespace SWAPIExample.Models
{
    public class SWAPIDAL
    {
        public SWPerson GetPerson(int id)
        {
            RestClient client = new RestClient($"https://swapi.dev/api/people/{id}/");
            RestRequest request = new RestRequest();
            Task<SWPerson> response = client.GetAsync<SWPerson>(request);
            SWPerson sp = response.Result;

            return sp;
        }
        public Planet GetPlanet(int id)
        {
            RestClient client = new RestClient($"https://swapi.dev/api/planets/{id}/");
            RestRequest request = new RestRequest();
            var response = client.GetAsync<Planet>(request);
            Planet sp = response.Result;

            return sp;
        }
    }
}
