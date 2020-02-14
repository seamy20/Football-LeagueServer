using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Complaints
    {
        public int Id { get; set; }

        public string ComplaintID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int  MPRN { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string ComplaintType { get; set; }

        public DateTime ComplaintDateTime { get; set; }

        public string ComplaintDetails { get; set; }

        public string LoggedBy { get; set; }

        public string ClosedOnInitialContact { get; set; }

        public string SuspectedFraud { get; set; }

        public string EscalatedTo { get; set; }

        public DateTime DateCreated { get; set; }

        public string PIN{ get; set; }
    }
}
