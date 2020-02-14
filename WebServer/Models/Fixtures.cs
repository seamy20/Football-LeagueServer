using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Fixtures
    {
        public int Id { get; set; }

        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime FixtureDate { get; set; }
        public string Referee { get; set; }
        public string Venue { get; set; }
        public string Sponser { get; set; }

    }
}
