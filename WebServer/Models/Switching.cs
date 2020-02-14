using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class Switching
    {
        public int Id { get; set; }
        public string title { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string MPRN { get; set; }

        public string postCode { get; set; }
        public string doorNumber { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine4 { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string confirmEmail { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string referredBy { get; set; }
        public string paymentType { get; set; }
        public string meterType { get; set; }
        public string kpn { get; set; }
        public string switchoverDueDate { get; set; }
        public string dayMeterRead { get; set; }
        public string nightMeterRead { get; set; }
        public bool billPay { get; set; }
        public string accountFullname { get; set; }
        public string accountNumber { get; set; }
        public string accountSortCode { get; set; }
        public string paymentDate { get; set; }
        public string paymentAmount { get; set; }
        public bool jointAccount { get; set; }
        public string jointTitle { get; set; }
        public string jointFirstName { get; set; }
        public string jointLastName { get; set; }
        public string jointEmail { get; set; }
        public string jointConfirmEmail { get; set; }
        public string jointMobile { get; set; }
        public bool speicalServices { get; set; }
        public string speicalServicesOption { get; set; }
        public bool medicalEquipment { get; set; }
        public string medicalEquipmentOption { get; set; }
        public bool billingAddress { get; set; }
        public string billingFullName { get; set; }
        public string billingPostcode { get; set; }
        public string billingDoorNumber { get; set; }
        public string billingStreet { get; set; }
        public string billingCity { get; set; }
        public string billingCounty { get; set; }
        public bool yourPremises { get; set; }
        public bool authorisation { get; set; }
        public bool authorisationError { get; set; }
        public string salesRepID { get; set; }
    
    }
}