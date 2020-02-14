using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Results
    {
        public int Id { get; set; }

        public string HomeName { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeamGoals { get; set; }
        public string AwayTeamGoals { get; set; }
        public string HomeNameRedCards { get; set; }
        public string AwayNameRedCards { get; set; }
        public string HomeNameYellowCards { get; set; }
        public string AwayNameYellowCards { get; set; }
    }
}
