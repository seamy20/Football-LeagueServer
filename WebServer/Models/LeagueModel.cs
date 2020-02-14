using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class LeagueModel
    {
        public int Id { get; set; }

        public string LeagueName { get; set; }

        public string Division { get; set; }
        
        public string Region{ get; set; }
    }
}
