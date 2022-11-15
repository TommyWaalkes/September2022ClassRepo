namespace MockAssessment7.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
        public int PlayerClassId { get; set; }
        public Player(int id, string username, int lvl, int playerclassid)
        {
            this.ID = id;
            this.UserName = username;
            this.Level = lvl;
            this.PlayerClassId = playerclassid;
        }
    }
}
