using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Teams
    {
        public int Id { get; set; }

        public string TeamName { get; set; }
        public string TeamLogo { get; set; }
        public string LeagueID { get; set; }
        public string Wins { get; set; }
        public string Draws { get; set; }
        public string Lost { get; set; }
        public string GoalsFor { get; set; }
        public string GoalsAgainst { get; set; }
        public string GoalsDifference { get; set; }
        public string MatchesPlayed { get; set; }
        public int Points { get; set; }
        public string HomeWins{ get; set; }
        public string HomeDraws { get; set; }
        public string HomeDefeats { get; set; }
        public string HomeGoalsFor { get; set; }
        public string HomeGoalsAgainst{ get; set; }
        public string AwayWins { get; set; }
        public string AwayDraws { get; set; }
        public string AwayDefeats { get; set; }
        public string AwayGoalsFor { get; set; }
        public string AwayGoalsAgainst { get; set; }
    }
}
