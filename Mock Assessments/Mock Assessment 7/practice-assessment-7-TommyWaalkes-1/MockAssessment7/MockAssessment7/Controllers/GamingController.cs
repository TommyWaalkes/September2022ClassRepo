using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7.Models;

namespace MockAssessment7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamingController : ControllerBase
    {
        GameDB DB = new GameDB();

        [HttpGet("Players")]
        public List<Player> GetPlayers()
        {
            return DB.Players;
        }

        [HttpGet("Classes")]
        public List<PlayerClass> GetClasses()
        {
            return DB.PlayerClasses;
        }

        [HttpGet("PlayersMinLevel/{level}")]
        public List<Player> GetMinLevelPlayers(int level)
        {
            List<Player> output = DB.Players.Where(p => p.Level >= level).ToList();
            return output;
        }

        [HttpGet("SortedPlayers")]
        public List<Player> GetSortedPlayers()
        {
            List<Player> output = DB.Players.OrderByDescending(p => p.Level).ToList();
            return output;
        }

        [HttpGet("GetPlayersByClass/{className}")]
        public List<Player> GetPlayersByClass(string className)
        {
            PlayerClass pc = DB.PlayerClasses.Where(c => c.Name == className).First();
            int id = pc.ID;

            return DB.Players.Where(p => p.PlayerClassId == id).ToList();
        }

        [HttpGet("GetPlayersByType/{classType}")]
        public List<Player> GetPlayersByType(string classType)
        {
            List<PlayerClass> pcs = DB.PlayerClasses.Where(pc => pc.Type == classType).ToList();

            List<Player> output = new List<Player>();

            foreach(PlayerClass pc in pcs)
            {
                List<Player> matches = DB.Players.Where( p=> p.PlayerClassId == pc.ID).ToList();
                output.AddRange(matches);
            }

            return output;
        }

        [HttpGet("GetAllPlayedClasses")]
        public List<PlayerClass> GetAllPlayedClasses()
        {
            List<PlayerClass> output = new List<PlayerClass>();

            foreach(Player p in DB.Players)
            {
                PlayerClass pc = DB.PlayerClasses.Where(c => c.ID == p.PlayerClassId).First();

                if (!output.Contains(pc))
                {
                    output.Add(pc);
                }
            }

            return output;
        }
    }
}
