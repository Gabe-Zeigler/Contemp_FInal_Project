using System.ComponentModel.DataAnnotations;

namespace Contemp_FInal_Project.Tables
{
    public class VideGamesTable
    {
        [Key]
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public double Ratings { get; set; }
        public VideGamesTable() { }
        public VideGamesTable(int gameID, string gameName, string releaseDate, string publisher, double ratings)
        {
            GameID = gameID;
            GameName = gameName;
            ReleaseDate = releaseDate;
            Publisher = publisher;
            Ratings = ratings;
        }
    }
}
