using DeckOfCardsGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsGame.Controllers
{
    public class HomeController : Controller
    {
        DoCDAL api = new DoCDAL();

        enum CARD_VALUE
        {
            ACE,
            KING,
            QUEEN,
            JACK
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            Deck startingDeck = api.GetDeck();
            Draws d = api.GetCards(2,startingDeck.deck_id);
            Card card1 = d.cards[0];
            Card card2 = d.cards[1];

            int numericValue1;
            int numericValue2;

            // Try to convert to a nubmer, otherwise it is a face card
            if(!int.TryParse(card1.value, out numericValue1))
            {
                CARD_VALUE face = (CARD_VALUE) Enum.Parse(typeof(CARD_VALUE), card1.value);
                numericValue1 = 14 - (int)face;
            }

            if (!int.TryParse(card2.value, out numericValue2))
            {
                CARD_VALUE face = (CARD_VALUE)Enum.Parse(typeof(CARD_VALUE), card2.value);
                numericValue2 = 14 - (int)face;
            }

            if(numericValue1 > numericValue2)
            {
                d.Winner = "Player 1 is the winner!";
            }
            else if(numericValue1 < numericValue2)
            {
                d.Winner = "Player 2 is the winner!";
            }
            else
            {
                d.Winner = "It is a draw!";
>>>>>>> f86fb310f88305b1ac5379b9d708ed0241051d33
            }

            return View(d);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}