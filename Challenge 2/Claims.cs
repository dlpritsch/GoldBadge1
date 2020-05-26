using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {

        public int ClaimID { get; set; }

        public string ClaimType { get; set; }

        public string Description { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid
        {
            get
            {
                TimeSpan difference = DateOfClaim - DateOfIncident;
                if (difference.Days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Claim() { }

        public Claim(int claimID, string claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)   //Constructor: refers to the menu items created in unit test.
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;

        }

    }
}
    
