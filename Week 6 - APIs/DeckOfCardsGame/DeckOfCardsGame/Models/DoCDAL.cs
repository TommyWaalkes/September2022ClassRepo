using RestSharp;

namespace DeckOfCardsGame.Models
{
    public class DoCDAL
    {
        //We need to shuffle a deck before we can draw cards, so we need to call this first before can we can call get cards
        public Deck GetDeck()
        {
            RestClient client = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            RestRequest request = new RestRequest();
            var response = client.GetAsync<Deck>(request);

            return response.Result;
        }

        public Draws GetCards(int draws,string deckId)
        {
            RestClient client = new RestClient($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={draws}");
            RestRequest request = new RestRequest();
            var response = client.GetAsync<Draws>(request);
            return response.Result;
        }


    }
}
