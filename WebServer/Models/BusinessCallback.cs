using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class BusinessCallback
    {
        public int Id { get; set; }

        public string BusinessName { get; set; }

        public string FirstName { get; set; }
        
        public string LastName{ get; set; }
        
        public string Email{ get; set; }
        
        public string Phone{ get; set; }
        
        public string ContactTime{ get; set; }
    }
}
