using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class SalesReps
    {
        public int Id { get; set; }
        public string budgetID { get; set; }
        public string password { get; set; }
        public string jurisdiction { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }        
        public string dateOfIssue { get; set; }        
        public string salesManager { get; set; }        
        public string tabletSerialNO { get; set; }        
        public bool Active { get; set; }        
        public string accessNI { get; set; }        
        public string Agency { get; set; }    
        public string Assessment { get; set; }    
        public string TrainingStatus { get; set; }    
        public string CompletionDate  { get; set; }    
        public string Expiry  { get; set; }    

    }
}
