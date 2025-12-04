using System.ComponentModel.DataAnnotations;

namespace Contemp_FInal_Project.Tables
{
    public class VideoGamesTable
    {
        [Key]
        public int GameID { get; set; }
        public string GameName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public double Ratings { get; set; }
        public VideoGamesTable() { }
        public VideoGamesTable(int gameID, string gameName, DateTime releaseDate, string publisher, double ratings)
        {
            GameID = gameID;
            GameName = gameName;
            ReleaseDate = releaseDate;
            Publisher = publisher;
            Ratings = ratings;
        }
    }
}
