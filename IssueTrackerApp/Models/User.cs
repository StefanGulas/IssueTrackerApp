using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTrackerApp.Models
{
    public class User
    {
        public User()
        {

        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public enum UCategory
        {
            Developer,
            Manager,
            ProductOwner,
            Kunde,
            ServicePartner
        }
        public UCategory UserCategory { get; set; }
    }
}
