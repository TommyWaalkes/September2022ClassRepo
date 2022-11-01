using RestSharp;

namespace Spoontacular.Models
{
    public class SpoonDAL
    {
        public string key = "ab79aad70a9d4927996be4d2a763719b";
        public RecipesResults GetResults(string query)
        {
            var client = 
                new RestClient($"https://api.spoonacular.com/recipes/complexSearch?query={query}&apiKey={key}");
            var request = new RestRequest();
            var response = client.GetAsync<RecipesResults>(request);
            RecipesResults results = response.Result;

            return results;
        }

        //Advice for figuring out the URL 
        //Start with a specific search to see how everything is arranged 
        //When moving it into your code, write generalized, how do I get this search to work on any term? 
        public Recipe GetRecipe(int id)
        {
            var client =
                new RestClient($"https://api.spoonacular.com/recipes/{id}/information?apiKey={key}");
            var request = new RestRequest();
            var response = client.GetAsync<Recipe>(request);
            Recipe results = response.Result;

            return results;
        }
    }
}
