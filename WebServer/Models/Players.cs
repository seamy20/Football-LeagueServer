using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Players
    {
        public int Id { get; set; }

        public string PlayerName { get; set; }
        public string TeamId { get; set; }
        public string GoalsScored { get; set; }
        public string Position { get; set; }
        public string CleanSheets { get; set; }
        public string YellowCards { get; set; }
        public string RedCards { get; set; }
    }
}
