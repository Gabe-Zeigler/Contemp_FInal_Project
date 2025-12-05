using System.ComponentModel.DataAnnotations;

namespace Contemp_FInal_Project.Models
{
    public class Sport
    {

        public int SportId { get; set; }          // PK
        public string Name { get; set; } = null!; // e.g., Basketball, Soccer
        public int PlayersPerTeam { get; set; }   // e.g., 5, 11, etc.
        public string Equipment { get; set; } = null!; // Ball, racket, etc.

        public bool IsOlympicSport { get; set; }  // true/false

        public Sport()
        {
        }

        public Sport(int sportId, string name, int playersPerTeam, string equipment, bool isOlympicSport)
        {
            SportId = sportId;
            Name = name;
            PlayersPerTeam = playersPerTeam;
            Equipment = equipment;
            IsOlympicSport = isOlympicSport;
        }

    }
}
