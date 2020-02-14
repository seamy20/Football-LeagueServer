using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class MovingHomeBillPay
    {
        public int Id { get; set; }
        public string title { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        //public string telephone { get; set; }
        public string accountNumber { get; set; }
        public string contactNumber { get; set; }
        public string email { get; set; }
        public string currentPostcode { get; set; }
        public string currentDoorNumber { get; set; }
        public string currentStreet { get; set; }
        public string currentCity { get; set; }
        public string newPostcode { get; set; }
        public string newDoorNumber { get; set; }
        public string newStreet { get; set; }
        public string newCity { get; set; }
        public string moveOutDate { get; set; }
        public string moveInDate { get; set; }
        public string dayMeterRead { get; set; }
        public string nightMeterRead { get; set; }
        public string contactTime { get; set; }
        public string contactError { get; set; }



    }
}